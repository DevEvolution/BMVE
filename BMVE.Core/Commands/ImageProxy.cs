using BMVE.Core.Utils.Utils;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal class ImageProxy
    {
        internal static void Image_Load(int number, string path)
        {
            AssertSocketIsFree(number);

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                var bitmap = SKBitmap.Decode(fileStream);
                var socket = new ImageSocket() 
                { 
                    Image = bitmap, 
                    TransformedImage = bitmap, 
                    Angle = 0 
                };
                ManagedSocketResolver
                    .ImageSocket
                    .OpenNewSocket(number, socket);
            }
        }

        internal static bool Image_IsLoaded(int number) 
            => ManagedSocketResolver
            .ImageSocket
            .IsSocketBusy(number);

        internal static void Image_Close(int number)
        {
            AssertSocketIsOpened(number);

            ManagedSocketResolver
                .ImageSocket
                .CloseSocket(number);
        }

        internal static void Image_Rotate(int number, double degrees)
        {
            AssertSocketIsOpened(number);

            var socket = ManagedSocketResolver
                .ImageSocket[number];

            double angle = degrees;
            socket.Angle = angle;
            double radians = Math.PI * angle / 180;
            float sine = (float)Math.Abs(Math.Sin(radians));
            float cosine = (float)Math.Abs(Math.Cos(radians));
            int originalWidth = socket.Image.Width;
            int originalHeight = socket.Image.Height;
            int rotatedWidth = (int)(cosine * originalWidth + sine * originalHeight);
            int rotatedHeight = (int)(cosine * originalHeight + sine * originalWidth);

            socket.TransformedImage = new SKBitmap(rotatedWidth, rotatedHeight);

            using (SKCanvas canvas = new SKCanvas(socket.TransformedImage))
            {
                canvas.Clear();
                canvas.Translate(rotatedWidth / 2, rotatedHeight / 2);
                canvas.RotateDegrees((float)angle);
                canvas.Translate(-originalWidth / 2, -originalHeight / 2);
                canvas.DrawBitmap(socket.Image, new SKPoint());
            }
        }

        internal static int Image_GetWidth(int number) 
        {
            AssertSocketIsOpened(number);

            return ManagedSocketResolver
                .ImageSocket[number]
                .Image
                .Width;
        }

        internal static int Image_GetHeight(int number)
        {
            AssertSocketIsOpened(number);

            return ManagedSocketResolver
                .ImageSocket[number]
                .Image
                .Height;
        }

        internal static double Image_GetAngle(int number)
        {
            AssertSocketIsOpened(number);

            return ManagedSocketResolver
                .ImageSocket[number]
                .Angle;
        }

        private static void AssertSocketIsOpened(int number)
        {
            if (!ManagedSocketResolver
                .ImageSocket
                .IsSocketBusy(number))
                throw new Exception($"Изображение №{number} не открыто");
        }

        private static void AssertSocketIsFree(int number)
        {
            if (ManagedSocketResolver
                .ImageSocket
                .IsSocketBusy(number))
            {
                throw new Exception($"Изображение №{number} уже открыто");
            }
        }
    }
}
