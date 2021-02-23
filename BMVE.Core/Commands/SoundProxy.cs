using BMVE.Core.Enums;
using BMVE.Core.Utils.Utils;
using NAudio.Midi;
using NAudio.Vorbis;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Commands
{
    internal static class SoundProxy
    {
        private static Dictionary<int, SoundSocket> soundSocketDict = new Dictionary<int, SoundSocket>();

        internal static void Sound_Load(int number, string filename)
        {
            CheckSoundAlreadyOpened(number);
            AudioFormat format = GetAudioFormat(filename);

            soundSocketDict[number] = new SoundSocket() { Filename = filename };
            soundSocketDict[number].Stream = new MemoryStream(File.ReadAllBytes(filename));
            soundSocketDict[number].Stream.Position = 0;
            switch (format)
            {
                case AudioFormat.Mp3:
                    soundSocketDict[number].Reader = new Mp3FileReader(soundSocketDict[number].Stream);
                    break;
                
                case AudioFormat.Wave:
                    soundSocketDict[number].Reader = new WaveFileReader(soundSocketDict[number].Stream);
                    break;

                case AudioFormat.Ogg:
                    soundSocketDict[number].Reader = new VorbisWaveReader(soundSocketDict[number].Stream);
                    break;
            }
            soundSocketDict[number].Player = new WaveOut();
            soundSocketDict[number].Player.Init(soundSocketDict[number].Reader);
            soundSocketDict[number].SocketState = SoundSocketState.Loaded;
        }

        internal static bool Sound_IsLoaded(int number) => soundSocketDict.ContainsKey(number) && soundSocketDict[number].SocketState != Enums.SoundSocketState.None;
        internal static void Sound_Play(int number)
        {
            CheckSocketNotOpened(number);

            soundSocketDict[number].Player.Play();
        }

        internal static void Sound_Pause(int number) 
        {
            CheckSocketNotOpened(number);

            soundSocketDict[number].Player.Pause();
        }
        internal static void Sound_Stop(int number)
        {
            CheckSocketNotOpened(number);

            soundSocketDict[number].Player.Stop();
        }

        internal static void Sound_SetVolume(int number, int volume)
        {
            CheckSocketNotOpened(number);
            if (volume < 0 || volume > 100)
                throw new Exception("Громкость аудио не может быть больше 100");

            soundSocketDict[number].Player.Volume = volume / 100f;
        }

        internal static int Sound_GetVolume(int number)
        {
            CheckSocketNotOpened(number);

            return (int)(soundSocketDict[number].Player.Volume * 100);
        }

        internal static void Sound_Close(int number)
        {
            CheckSocketNotOpened(number);
            soundSocketDict[number].SocketState = Enums.SoundSocketState.None;
            soundSocketDict[number].Player.Stop();
            soundSocketDict[number].Reader.Dispose();
            soundSocketDict[number].Stream.Dispose();
            soundSocketDict[number].Player.Dispose();
            soundSocketDict[number] = null;
        }

        private static void CheckSoundAlreadyOpened(int number)
        {
            if (soundSocketDict.ContainsKey(number) && soundSocketDict[number].SocketState != Enums.SoundSocketState.Stopped)
            {
                var socket = soundSocketDict[number];
                switch (socket.SocketState)
                {
                    case Enums.SoundSocketState.Stopped:
                    case Enums.SoundSocketState.Playing:
                        throw new Exception($"Аудиофайл №{number} уже открыт");
                }
            }
        }

        private static void CheckSocketNotOpened(int number)
        {
            if (!soundSocketDict.ContainsKey(number) || soundSocketDict[number].SocketState == Enums.SoundSocketState.None)
                throw new Exception($"Аудиофайл №{number} не открыт");
        }

        private static AudioFormat GetAudioFormat(string filename)
        {
            if (filename.EndsWith(".mp3")) return AudioFormat.Mp3;
            else if (filename.EndsWith(".vaw")) return AudioFormat.Wave;
            else if (filename.EndsWith(".ogg")) return AudioFormat.Ogg;
            else if (filename.EndsWith(".mid") || filename.EndsWith(".midi")) return AudioFormat.Midi;
            else throw new Exception("Неподдерживаемый формат звукового файла");
        }
    }
}
