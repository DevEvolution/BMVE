using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class SpeechProxy
    {
        private static SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        private static SpeechSynthesizer _synthesizer = new SpeechSynthesizer();

        private static StringBuilder _recognizedTextBuffer = new StringBuilder();
        private static bool _isConfigured = false;

        internal static string[] Speech_GetAvailableRecognitionLanguages()
        {
            return SpeechRecognitionEngine.InstalledRecognizers()
                .Select(x => x.Culture.Name)
                .ToArray();
        }

        internal static void Speech_SetRecognitionLanguage(string languageCode)
        {
            RecognizerInfo recognizerInfo = SpeechRecognitionEngine.InstalledRecognizers()
                .FirstOrDefault(x => x.Culture.Name.ToLower() == languageCode.ToLower());

            if (recognizerInfo == null) throw new Exception("Указанный язык не установлен для распознавания речи");

            _recognizer = new SpeechRecognitionEngine(recognizerInfo.Culture);
            _isConfigured = false;
        }

        internal static void Speech_StartRecognition()
        {
            _recognizedTextBuffer.Clear();
            if (!_isConfigured)
            {
                _recognizer.LoadGrammar(new DictationGrammar());
                _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;
                _recognizer.SetInputToDefaultAudioDevice();
                _isConfigured = true;
            }
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        internal static void Speech_StopRecognition()
        {
            _recognizer.RecognizeAsyncStop();
        }

        internal static string Speech_GetRecognizedText()
        {
            return _recognizedTextBuffer.ToString();
        }

        internal static void Speech_ClearRecognizedText()
        {
            _recognizedTextBuffer.Clear();
        }

        internal static string[] Speech_GetAvailableSynthesizers()
        {
            return _synthesizer.GetInstalledVoices()
                .Select(x => x.VoiceInfo.Name)
                .ToArray();
        }

        internal static string Speech_GetSynthesizerLanguage(string synthesizerName)
        {
            InstalledVoice voice = _synthesizer.GetInstalledVoices()
                .FirstOrDefault(x => x.VoiceInfo.Name == synthesizerName);

            if (voice == null) throw new Exception("Отсутствует синтезатор речи с указанным именем");

            return voice.VoiceInfo.Culture.Name;
        }

        internal static string Speech_GetCurrentSynthesizer()
        {
            return _synthesizer.Voice.Name;
        }

        internal static void Speech_SetCurrentSynthesizer(string synthesizerName)
        {
            _synthesizer.SelectVoice(synthesizerName);
        }

        internal static void Speech_SynthesizerSpeak(string text)
        {
            _synthesizer.SpeakAsync(text);
        }

        internal static bool Speech_IsSynthesizerSpeaking()
        {
            return _synthesizer.State == SynthesizerState.Speaking;
        }

        internal static string Speech_ReadStringBySpeech()
        {
            return _recognizer.Recognize().Text;
        }

        private static void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            _recognizedTextBuffer.Append(' ');
            _recognizedTextBuffer.Append(e.Result.Text);
        }
    }
}
