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
        internal static Dictionary<int, ImageSocket> imageSocketDict = new Dictionary<int, ImageSocket>();

        internal static void Image_Load(int number, string path)
        {
            if (imageSocketDict.ContainsKey(number))
                throw new Exception($"Изображение №{number} уже открыто");

            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                var bitmap = SKBitmap.Decode(fileStream);
                imageSocketDict[number] = new ImageSocket() { Image = bitmap, TransformedImage = bitmap, Angle = 0 };
            }
        }

        internal static bool Image_IsLoaded(int number) => imageSocketDict.ContainsKey(number);

        internal static void Image_Close(int number)
        {
            CheckSocketNotOpened(number);

            imageSocketDict[number].TransformedImage.Dispose();
            imageSocketDict[number].Image.Dispose();
            imageSocketDict[number] = null;
        }

        internal static void Image_Rotate(int number, double degrees)
        {
            CheckSocketNotOpened(number);

            double angle = degrees;
            imageSocketDict[number].Angle = angle;
            double radians = Math.PI * angle / 180;
            float sine = (float)Math.Abs(Math.Sin(radians));
            float cosine = (float)Math.Abs(Math.Cos(radians));
            int originalWidth = imageSocketDict[number].Image.Width;
            int originalHeight = imageSocketDict[number].Image.Height;
            int rotatedWidth = (int)(cosine * originalWidth + sine * originalHeight);
            int rotatedHeight = (int)(cosine * originalHeight + sine * originalWidth);

            imageSocketDict[number].TransformedImage = new SKBitmap(rotatedWidth, rotatedHeight);

            using (SKCanvas canvas = new SKCanvas(imageSocketDict[number].TransformedImage))
            {
                canvas.Clear();
                canvas.Translate(rotatedWidth / 2, rotatedHeight / 2);
                canvas.RotateDegrees((float)angle);
                canvas.Translate(-originalWidth / 2, -originalHeight / 2);
                canvas.DrawBitmap(imageSocketDict[number].Image, new SKPoint());
            }
        }
        internal static int Image_GetWidth(int number) 
        {
            CheckSocketNotOpened(number);
            return imageSocketDict[number].Image.Width;
        }
        internal static int Image_GetHeight(int number)
        {
            CheckSocketNotOpened(number);
            return imageSocketDict[number].Image.Height;
        }

        internal static double Image_GetAngle(int number)
        {
            CheckSocketNotOpened(number);
            return imageSocketDict[number].Angle;
        }

        private static void CheckSocketNotOpened(int number)
        {
            if (!imageSocketDict.ContainsKey(number))
                throw new Exception($"Изображение №{number} не открыто");
        }
    }
}
