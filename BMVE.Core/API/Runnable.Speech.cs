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
        /// Получает список всех доступных языков для распознавания речи
        /// </summary>
        /// <returns>Список всех доступных языков для распознавания речи</returns>
        protected string[] Speech_GetAvailableRecognitionLanguages() => SpeechProxy.Speech_GetAvailableRecognitionLanguages();

        /// <summary>
        /// Устанавливает язык распознавания речи
        /// </summary>
        /// <param name="languageCode">Код языка распознавания речи, например "en_US"</param>
        protected void Speech_SetRecognitionLanguage(string languageCode) => SpeechProxy.Speech_SetRecognitionLanguage(languageCode);

        /// <summary>
        /// Начинает распознавание речи
        /// </summary>
        protected void Speech_StartRecognition() => SpeechProxy.Speech_StartRecognition();

        /// <summary>
        /// Останавливает распознавание речи. <br />ВНИМАНИЕ!!! Остановка распознавания проиходит не сразу и требует некоторой задержки перед считыванием распознанного текста.
        /// </summary>
        protected void Speech_StopRecognition() => SpeechProxy.Speech_StopRecognition();

        /// <summary>
        /// Получить распознанный текст
        /// </summary>
        /// <returns>Распознанный текст</returns>
        protected string Speech_GetRecognizedText() => SpeechProxy.Speech_GetRecognizedText();

        /// <summary>
        /// Очищает распознанный текст
        /// </summary>
        protected void Speech_ClearRecognizedText() => SpeechProxy.Speech_ClearRecognizedText();

        /// <summary>
        /// Получает список имён доступных речевых синтезаторов
        /// </summary>
        /// <returns>Список имён доступных речевых синтезаторов</returns>
        protected string[] Speech_GetAvailableSynthesizers() => SpeechProxy.Speech_GetAvailableSynthesizers();

        /// <summary>
        /// Получить язык указанного речевого синтезатора
        /// </summary>
        /// <param name="synthesizerName">Имя речевого синтезатора</param>
        /// <returns>Язык речевого синтезатора</returns>
        protected string Speech_GetSynthesizerLanguage(string synthesizerName) => SpeechProxy.Speech_GetSynthesizerLanguage(synthesizerName);

        /// <summary>
        /// Получить имя текущего речевого синтезатора
        /// </summary>
        /// <returns>Имя текущего речевого синтезатора</returns>
        protected string Speech_GetCurrentSynthesizer() => SpeechProxy.Speech_GetCurrentSynthesizer();

        /// <summary>
        /// Задать синтезатор речи
        /// </summary>
        /// <param name="synthesizerName">Имя речевого синтезатора</param>
        protected void Speech_SetCurrentSynthesizer(string synthesizerName) => SpeechProxy.Speech_SetCurrentSynthesizer(synthesizerName);

        /// <summary>
        /// Читает заданный текст при помощи текущего речевого синтезатора
        /// </summary>
        /// <param name="text">Текст для прочтения речевым синтезатором</param>
        protected void Speech_SynthesizerSpeak(string text) => SpeechProxy.Speech_SynthesizerSpeak(text);

        /// <summary>
        /// Читает ли текст ли синтезатор в данный момент
        /// </summary>
        /// <returns>Читает ли текст ли синтезатор в данный момент</returns>
        protected bool Speech_IsSynthesizerSpeaking() => SpeechProxy.Speech_IsSynthesizerSpeaking();
    }
}
