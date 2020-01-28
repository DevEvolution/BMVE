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
        internal static bool File_Exists(string path) => File.Exists(path);
        internal static bool File_DirectoryExists(string path) => Directory.Exists(path);
        internal static bool File_IsOpened(int number) => fileSocketDict.ContainsKey(number) && fileSocketDict[number].SocketState != Enums.FileSocketState.Closed;
        internal static bool File_IsOpenedToRead(int number) => fileSocketDict.ContainsKey(number) && fileSocketDict[number].SocketState == Enums.FileSocketState.OpenedToRead;
        internal static bool File_IsOpenedToWrite(int number) => fileSocketDict.ContainsKey(number) && fileSocketDict[number].SocketState == Enums.FileSocketState.OpenedToWrite;
        internal static void File_OpenToRead(int number, string path)
        {
            CheckFileAlreadyOpened(number);

            Stream fileStream = new FileStream(path, FileMode.Open);
            fileSocketDict[number] = new FileSocket() { Filename = path, Stream = fileStream };
            fileSocketDict[number].Reader = new StreamReader(fileStream);
            fileSocketDict[number].SocketState = Enums.FileSocketState.OpenedToRead;
        }

        internal static void File_OpenToWrite(int number, string path)
        {
            CheckFileAlreadyOpened(number);

            Stream fileStream = new FileStream(path, FileMode.Create);
            fileSocketDict[number] = new FileSocket() { Filename = path, Stream = fileStream };
            fileSocketDict[number].Writer = new StreamWriter(fileStream);
            fileSocketDict[number].SocketState = Enums.FileSocketState.OpenedToWrite;
        }
        internal static void File_Close(int number)
        {
            if (fileSocketDict.ContainsKey(number) && fileSocketDict[number].SocketState != Enums.FileSocketState.Closed)
            {
                fileSocketDict[number].Reader?.Dispose();
                fileSocketDict[number].Writer?.Dispose();
                fileSocketDict[number].Stream?.Dispose();
                fileSocketDict.Remove(number);
            }
        }

        internal static string File_ReadLine(int number)
        {
            CheckSocketExists(number);
            CheckSocketNotOpenedToRead(number);

            return fileSocketDict[number].Reader.ReadLine();
        }

        internal static void File_WriteLine(int number, params string[] text)
        {
            CheckSocketExists(number);
            CheckSocketNotOpenedToWrite(number);

            string fullText = string.Concat(text.Select(x => x.ToString()));

            fileSocketDict[number].Writer.WriteLine(fullText);
        }

        internal static void File_Write(int number, params string[] text)
        {
            CheckSocketExists(number);
            CheckSocketNotOpenedToWrite(number);

            string fullText = string.Concat(text.Select(x => x.ToString()));

            fileSocketDict[number].Writer.Write(fullText);
        }

        internal static bool File_IsEnd(int number)
        {
            CheckSocketExists(number);
            CheckSocketNotOpenedToRead(number);

            return fileSocketDict[number].Reader.EndOfStream;
        }

        internal static string[] File_GetDirectories() => Directory.GetDirectories(Environment.CurrentDirectory);
        internal static string[] File_GetFiles() => Directory.GetFiles(Environment.CurrentDirectory);
        internal static void File_SetCurrentDirectory(string path) => Environment.CurrentDirectory = path;
        internal static string File_GetCurrentDirectory() => Environment.CurrentDirectory;
        internal static void File_CreateDirectory(string directoryName) => Directory.CreateDirectory(directoryName);
        internal static void File_RenameDirectory(string oldName, string newName) => Directory.Move(oldName, newName);
        internal static void File_DeleteDirectory(string directoryName) => Directory.Delete(directoryName);
        internal static void File_Rename(string oldName, string newName) => File.Move(oldName, newName);
        internal static void File_Delete(string fileName) => File.Delete(fileName);
        internal static void File_Copy(string path, string newPath) => File.Copy(path, newPath);
        internal static void File_Move(string path, string newPath) => File.Move(path, newPath);

        internal static string File_GetFilenameFromPath(string path) => new PathResolver().ResolvePath(path).Filename;
        internal static string File_GetDirectoryPathFromPath(string path) => new PathResolver().ResolvePath(path).Path;

        #region Implementation
        private static Dictionary<int, FileSocket> fileSocketDict = new Dictionary<int, FileSocket>();

        private static void CheckSocketExists(int number)
        {
            if (!fileSocketDict.ContainsKey(number))
                throw new Exception($"Файл №{number} не был открыт");
        }

        private static void CheckSocketNotOpenedToRead(int number)
        {
            if (fileSocketDict[number].SocketState != Enums.FileSocketState.OpenedToRead)
                throw new Exception($"Файл №{number} не открыт для чтения");
        }

        private static void CheckSocketNotOpenedToWrite(int number)
        {
            if (fileSocketDict[number].SocketState != Enums.FileSocketState.OpenedToWrite)
                throw new Exception($"Файл №{number} не открыт для записи");
        }

        private static void CheckFileAlreadyOpened(int number)
        {
            if (fileSocketDict.ContainsKey(number) && fileSocketDict[number].SocketState != Enums.FileSocketState.Closed)
            {
                var socket = fileSocketDict[number];
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
        #endregion
    }
}
