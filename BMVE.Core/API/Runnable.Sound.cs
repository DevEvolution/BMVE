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
        /// Загружает аудиофайл
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        /// <param name="filename">Путь к файлу</param>
        protected void Sound_Load(int number, string filename) => SoundProxy.Sound_Load(number, filename);

        /// <summary>
        /// Загружен ли аудиофайл с указанным номером
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        /// <returns>Загружен ли аудиофайл с указанным номером</returns>
        protected bool Sound_IsLoaded(int number) => SoundProxy.Sound_IsLoaded(number);

        /// <summary>
        /// Запускает воспроизведение аудиофайла
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        protected void Sound_Play(int number) => SoundProxy.Sound_Play(number);

        /// <summary>
        /// Приостанавливает воспроизведение аудиофайла
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        protected void Sound_Pause(int number) => SoundProxy.Sound_Pause(number);

        /// <summary>
        /// Останавливает воспроизведение аудиофайла
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        protected void Sound_Stop(int number) => SoundProxy.Sound_Stop(number);

        /// <summary>
        /// Задает громкость воспроизведения аудиофайла
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        /// <param name="volume">Громкость в процентном соотношении (от 0 до 100)</param>
        protected void Sound_SetVolume(int number, int volume) => SoundProxy.Sound_SetVolume(number, volume);

        /// <summary>
        /// Получает громкость воспроизведения аудиофайла
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        /// <returns>Громкость в процентном соотношении (от 0 до 100)</returns>
        protected int Sound_GetVolume(int number) => SoundProxy.Sound_GetVolume(number);

        /// <summary>
        /// Закрывает аудиофайл
        /// </summary>
        /// <param name="number">Номер аудиофайла</param>
        protected void Sound_Close(int number) => SoundProxy.Sound_Close(number);
    }
}
