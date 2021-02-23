using BMVE.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core
{
    public partial class Runnable
    {
        /// <summary>
        /// Проверяет наличие файла по указанному пути
        /// </summary>
        /// <param name="path">Путь к файлу в системе</param>
        /// <returns>Наличие/отсутствие файла</returns>
        protected bool File_Exists(string path) => FileProxy.File_Exists(path);

        /// <summary>
        /// Проверяет наличие каталога по указанному пути
        /// </summary>
        /// <param name="path">Путь к каталогу в системе</param>
        /// <returns>Наличие/отсутствие каталога</returns>
        protected bool File_DirectoryExists(string path) => FileProxy.File_DirectoryExists(path);

        /// <summary>
        /// Проверяет, занят ли номер для файла (открыт ли файл по указанному номеру)
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <returns>Номер занят/свободен</returns>
        protected bool File_IsOpened(int number) => FileProxy.File_IsOpened(number);

        /// <summary>
        /// Проверяет, открыт ли файл для чтения по указанному номеру
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <returns>Файл открыт/не открыт</returns>
        protected bool File_IsOpenedToRead(int number) => FileProxy.File_IsOpenedToRead(number);

        /// <summary>
        /// Проверяет, открыт ли файл для записи по указанному номеру
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <returns>Файл открыт/не открыт</returns>
        protected bool File_IsOpenedToWrite(int number) => FileProxy.File_IsOpenedToWrite(number);

        /// <summary>
        /// Открывает файл для чтения под указанным номером
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="path">Путь к файлу</param>
        protected void File_OpenToRead(int number, string path) => FileProxy.File_OpenToRead(number, path);

        /// <summary>
        /// Открывает файл для записи под указанным номером
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="path">Путь к файлу</param>
        protected void File_OpenToWrite(int number, string path) => FileProxy.File_OpenToWrite(number, path);

        /// <summary>
        /// Закрывает файл
        /// </summary>
        /// <param name="number">Номер файла</param>
        protected void File_Close(int number) => FileProxy.File_Close(number);

        /// <summary>
        /// Чтение строки текста из файла
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <returns>Строка из файла</returns>
        protected string File_ReadLine(int number) => FileProxy.File_ReadLine(number);

        /// <summary>
        /// Чтение бинарных данных из файла
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="length">Количество байт, которое необходимо считать</param>
        /// <returns>Бинарные данные из файла</returns>
        protected byte[] File_ReadBytes(int number, int length) => FileProxy.File_ReadBytes(number, length);

        /// <summary>
        /// Запись строки текста в файл, после записи осуществляет переход на новую строку
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="text">Строка для записи</param>
        protected void File_WriteLine(int number, params string[] text) => FileProxy.File_WriteLine(number, text);

        /// <summary>
        /// Запись строки текста в файл, не осуществляет переход на новую строку
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="text">Строка для записи</param>
        protected void File_Write(int number, params string[] text) => FileProxy.File_Write(number, text);

        /// <summary>
        /// Запись строки текста в файл, не осуществляет переход на новую строку
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="data">Бинарные данные для записи</param>
        protected void File_WriteBytes(int number, byte[] data) => FileProxy.File_WriteBytes(number, data);

        /// <summary>
        /// Проверяет, достигнут ли конец файла при чтении
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <returns>Конец файла достигнут/не достигнут</returns>
        protected bool File_IsEnd(int number) => FileProxy.File_IsEnd(number);

        /// <summary>
        /// Получает названия всех подкаталогов в текущем каталоге
        /// </summary>
        /// <returns>Массив имен всех подкаталогов в текущем каталоге</returns>
        protected string[] File_GetDirectories() => FileProxy.File_GetDirectories();

        /// <summary>
        /// Получает названия всех файлов в текущем каталоге
        /// </summary>
        /// <returns>Массив имен всех файлов в текущем каталоге</returns>
        protected string[] File_GetFiles() => FileProxy.File_GetFiles();

        /// <summary>
        /// Устанавливает текущий каталог
        /// </summary>
        /// <param name="path">Путь к каталогу</param>
        protected void File_SetCurrentDirectory(string path) => FileProxy.File_SetCurrentDirectory(path);

        /// <summary>
        /// Возвращает текущий каталог
        /// </summary>
        /// <returns>Путь к текущему каталогу</returns>
        protected string File_GetCurrentDirectory() => FileProxy.File_GetCurrentDirectory();

        /// <summary>
        /// Создает каталог по указанному пути
        /// </summary>
        /// <param name="directoryName">Путь к каталогу</param>
        protected void File_CreateDirectory(string directoryName) => FileProxy.File_CreateDirectory(directoryName);

        /// <summary>
        /// Переименовывает каталог
        /// </summary>
        /// <param name="oldName">Старое название каталога</param>
        /// <param name="newName">Новое название каталога</param>
        protected void File_RenameDirectory(string oldName, string newName) => FileProxy.File_RenameDirectory(oldName, newName);

        /// <summary>
        /// Удаляет каталог
        /// </summary>
        /// <param name="directoryName">Путь к каталогу</param>
        protected void File_DeleteDirectory(string directoryName) => FileProxy.File_DeleteDirectory(directoryName);

        /// <summary>
        /// Получить размер файла в байтах
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Размер файла в байтах</returns>
        protected long File_GetSize(string filename) => FileProxy.File_GetSize(filename);

        /// <summary>
        /// Получить текущий отступ файла для чтения/записи
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <returns>Отступ файла для чтения/записи</returns>
        protected long File_GetOffset(int number) => FileProxy.File_GetOffset(number);

        /// <summary>
        /// Задать текущий отступ файла для чтения/записи
        /// </summary>
        /// <param name="number">Номер файла</param>
        /// <param name="offset">Новый отступ файла для чтения/записи</param>
        protected void File_SetOffset(int number, long offset) => FileProxy.File_SetOffset(number, offset);

        /// <summary>
        /// Переименовывает файл
        /// </summary>
        /// <param name="oldName">Старое название файла</param>
        /// <param name="newName">Новое название файла</param>
        protected void File_Rename(string oldName, string newName) => FileProxy.File_Rename(oldName, newName);

        /// <summary>
        /// Удаляет файл
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        protected void File_Delete(string fileName) => FileProxy.File_Delete(fileName);

        /// <summary>
        /// Копирует файл
        /// </summary>
        /// <param name="path">Путь к копируемому файлу</param>
        /// <param name="newPath">Путь, где должна быть создана копия</param>
        protected void File_Copy(string path, string newPath) => FileProxy.File_Copy(path, newPath);

        /// <summary>
        /// Перемещает файл
        /// </summary>
        /// <param name="path">Путь к перемещаемому файлу</param>
        /// <param name="newPath">Путь, по которому файл должен быть перемещен</param>
        protected void File_Move(string path, string newPath) => FileProxy.File_Move(path, newPath);

        /// <summary>
        /// Получить имя конечного файла из пути
        /// </summary>
        /// <param name="path">Путь</param>
        /// <returns>Имя файла</returns>
        protected string File_GetFilenameFromPath(string path) => FileProxy.File_GetFilenameFromPath(path);

        /// <summary>
        /// Получить путь без указания конечного файла
        /// </summary>
        /// <param name="path">Путь</param>
        /// <returns>Путь без имени файла</returns>
        protected string File_GetDirectoryPathFromPath(string path) => FileProxy.File_GetDirectoryPathFromPath(path);
    }
}
