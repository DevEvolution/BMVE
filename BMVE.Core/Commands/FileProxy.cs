using BMVE.Core.Utils.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class FileProxy
    {
        internal static bool File_Exists(string path) 
            => File.Exists(path);

        internal static bool File_DirectoryExists(string path) 
            => Directory.Exists(path);

        internal static bool File_IsOpened(int number) 
            => ManagedSocketResolver.FileSocket.IsSocketBusy(number) 
            && ManagedSocketResolver.FileSocket[number].SocketState != Enums.FileSocketState.Closed;

        internal static bool File_IsOpenedToRead(int number) 
            => ManagedSocketResolver.FileSocket.IsSocketBusy(number) 
            && ManagedSocketResolver.FileSocket[number].SocketState == Enums.FileSocketState.OpenedToRead;

        internal static bool File_IsOpenedToWrite(int number) 
            => ManagedSocketResolver.FileSocket.IsSocketBusy(number) 
            && ManagedSocketResolver.FileSocket[number].SocketState == Enums.FileSocketState.OpenedToWrite;

        internal static void File_OpenToRead(int number, string path)
        {
            AssertFileIsNotOpened(number);

            Stream fileStream = new FileStream(path, FileMode.Open);
            var socket = new FileSocket() 
            { 
                Filename = path, 
                Stream = fileStream,
                Reader = new StreamReader(fileStream),
                SocketState = Enums.FileSocketState.OpenedToRead
            };

            ManagedSocketResolver
                .FileSocket
                .OpenNewSocket(number, socket);
        }

        internal static void File_OpenToWrite(int number, string path)
        {
            AssertFileIsNotOpened(number);

            Stream fileStream = new FileStream(path, FileMode.Create);

            var socket = new FileSocket()
            {
                Filename = path,
                Stream = fileStream,
                Writer = new StreamWriter(fileStream),
                SocketState = Enums.FileSocketState.OpenedToWrite
            };

            ManagedSocketResolver
                .FileSocket
                .OpenNewSocket(number, socket);
        }
        internal static void File_Close(int number)
        {
            AssertSocketExists(number);

            ManagedSocketResolver
                .FileSocket
                .CloseSocket(number);
        }

        internal static string File_ReadLine(int number)
        {
            AssertSocketExists(number);
            AssertSocketNotOpenedToRead(number);

            return ManagedSocketResolver
                .FileSocket[number]
                .Reader
                .ReadLine();
        }

        internal static byte[] File_ReadBytes(int number, int length)
        {
            AssertSocketExists(number);
            AssertSocketNotOpenedToRead(number);

            var baseStream = ManagedSocketResolver
                .FileSocket[number]
                .Reader
                .BaseStream;
            var buffer = new byte[length];

            baseStream.Read(buffer, (int)baseStream.Position, length);

            return buffer;
        }

        internal static void File_WriteLine(int number, params string[] text)
        {
            AssertSocketExists(number);
            AssertSocketNotOpenedToWrite(number);

            string fullText = string.Concat(text.Select(x => x.ToString()));

            ManagedSocketResolver
                .FileSocket[number]
                .Writer
                .WriteLine(fullText);
        }

        internal static void File_Write(int number, params string[] text)
        {
            AssertSocketExists(number);
            AssertSocketNotOpenedToWrite(number);

            string fullText = string.Concat(text.Select(x => x.ToString()));

            ManagedSocketResolver
                .FileSocket[number]
                .Writer
                .Write(fullText);
        }

        internal static void File_WriteBytes(int number, byte[] data)
        {
            AssertSocketExists(number);
            AssertSocketNotOpenedToWrite(number);

            var baseStream = ManagedSocketResolver
                .FileSocket[number]
                .Writer
                .BaseStream;

            baseStream.Write(data, (int)baseStream.Position, data.Length);
        }

        internal static bool File_IsEnd(int number)
        {
            AssertSocketExists(number);
            AssertSocketNotOpenedToRead(number);

            return ManagedSocketResolver
                .FileSocket[number]
                .Reader
                .EndOfStream;
        }

        internal static string[] File_GetDirectories() 
            => Directory.GetDirectories(Environment.CurrentDirectory);

        internal static string[] File_GetFiles() 
            => Directory.GetFiles(Environment.CurrentDirectory);

        internal static void File_SetCurrentDirectory(string path)
        {
            AssertDirectoryIsExists(path);

            Environment.CurrentDirectory = path;
        }
        internal static string File_GetCurrentDirectory() 
            => Environment.CurrentDirectory;

        internal static void File_CreateDirectory(string directoryName) 
            => Directory.CreateDirectory(directoryName);

        internal static void File_RenameDirectory(string oldName, string newName) 
        {
            AssertDirectoryIsExists(oldName);

            var newPath = new PathResolver()
                .ResolvePath(newName)
                .Filename;

            Directory.Move(oldName, newPath);
        }

        internal static void File_DeleteDirectory(string directoryName)
        {
            AssertDirectoryIsExists(directoryName);

            Directory.Delete(directoryName); 
        }
        internal static void File_Rename(string oldName, string newName) 
        {
            AssertFileIsExists(oldName);

            var newPath = new PathResolver()
                .ResolvePath(newName)
                .Filename;

            File.Move(oldName, newPath); 
        }
        internal static void File_Delete(string fileName)
        {
            AssertFileIsExists(fileName);

            File.Delete(fileName); 
        }

        internal static void File_Copy(string path, string newPath)
        {
            AssertFileIsExists(path);

            File.Copy(path, newPath);
        }

        internal static void File_Move(string path, string newPath)
        {
            AssertFileIsExists(path);

            File.Move(path, newPath);
        }

        internal static string File_GetFilenameFromPath(string path) 
            => new PathResolver()
            .ResolvePath(path)
            .Filename;

        internal static string File_GetDirectoryPathFromPath(string path)
            => new PathResolver()
            .ResolvePath(path)
            .Path;

        internal static long File_GetSize(string path)
        {
            AssertFileIsExists(path);

            return new FileInfo(path).Length;
        }

        internal static long File_GetOffset(int number)
        {
            AssertFileIsOpened(number);

            return ManagedSocketResolver
                .FileSocket[number]
                .Stream
                .Position;
        }

        internal static void File_SetOffset(int number, long offset)
        {
            AssertFileIsOpened(number);

            ManagedSocketResolver
                .FileSocket[number]
                .Stream
                .Position = offset;
        }

        #region Assert

        private static void AssertSocketExists(int number)
        {
            if (!ManagedSocketResolver
                .FileSocket
                .IsSocketBusy(number))
                throw new Exception($"Файл №{number} не был открыт");
        }

        private static void AssertSocketNotOpenedToRead(int number)
        {
            if (ManagedSocketResolver
                .FileSocket[number]
                .SocketState != Enums.FileSocketState.OpenedToRead)
                throw new Exception($"Файл №{number} не открыт для чтения");
        }

        private static void AssertSocketNotOpenedToWrite(int number)
        {
            if (ManagedSocketResolver
                .FileSocket[number]
                .SocketState != Enums.FileSocketState.OpenedToWrite)
                throw new Exception($"Файл №{number} не открыт для записи");
        }

        private static void AssertFileIsNotOpened(int number)
        {
            if (ManagedSocketResolver
                .FileSocket
                .IsSocketBusy(number))
            {
                var socket = ManagedSocketResolver
                    .FileSocket[number];

                switch (socket.SocketState)
                {
                    case Enums.FileSocketState.OpenedToRead:
                        throw new Exception($"Файл №{number} уже открыт для чтения");

                    case Enums.FileSocketState.OpenedToWrite:
                        throw new Exception($"Файл №{number} уже открыт для записи");

                    case Enums.FileSocketState.OpenedToAppend:
                        throw new Exception($"Файл №{number} уже открыт для дозаписи");
                }
            }
        }

        private static void AssertFileIsExists(string path)
        {
            if (!File.Exists(path))
                throw new Exception("Указанный файл не существует");
        }

        private static void AssertDirectoryIsExists(string path)
        {
            if (!Directory.Exists(path))
                throw new Exception("Указанная папка не существует");
        }

        private static void AssertFileIsOpened(int number)
        {
            if (!ManagedSocketResolver.FileSocket.IsSocketBusy(number)
                || ManagedSocketResolver.FileSocket[number].SocketState != Enums.FileSocketState.Closed)
            {
                throw new Exception($"Файл №{number} не открыт");
            }
        }
        #endregion
    }
}
