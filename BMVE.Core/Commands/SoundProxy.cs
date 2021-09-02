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
        internal static void Sound_Load(int number, string filename)
        {
            AssertSoundSocketIsFree(number);
            AudioFormat format = GetAudioFormat(filename);

            var socket = new SoundSocket() 
            { 
                Filename = filename, 
                Stream = new MemoryStream(File.ReadAllBytes(filename))
            };
            socket.Stream.Position = 0;
            switch (format)
            {
                case AudioFormat.Mp3:
                    socket.Reader = new Mp3FileReader(socket.Stream);
                    break;
                
                case AudioFormat.Wave:
                    socket.Reader = new WaveFileReader(socket.Stream);
                    break;

                case AudioFormat.Ogg:
                    socket.Reader = new VorbisWaveReader(socket.Stream);
                    break;
            }
            socket.Player = new WaveOut();
            socket.Player.Init(socket.Reader);
            socket.SocketState = SoundSocketState.Loaded;

            ManagedSocketResolver
                .SoundSocket
                .OpenNewSocket(number, socket);
        }

        internal static bool Sound_IsLoaded(int number)
            => ManagedSocketResolver
            .SoundSocket
            .IsSocketBusy(number) 
            && ManagedSocketResolver
            .SoundSocket[number]
            .SocketState != Enums.SoundSocketState.None;

        internal static void Sound_Play(int number)
        {
            AssertSocketIsOpened(number);

            ManagedSocketResolver
                .SoundSocket[number]
                .Player
                .Play();
        }

        internal static void Sound_Pause(int number) 
        {
            AssertSocketIsOpened(number);

            ManagedSocketResolver
                .SoundSocket[number]
                .Player
                .Pause();
        }
        internal static void Sound_Stop(int number)
        {
            AssertSocketIsOpened(number);

            ManagedSocketResolver
                .SoundSocket[number]
                .Player
                .Stop();
        }

        internal static void Sound_SetVolume(int number, int volume)
        {
            AssertSocketIsOpened(number);

            if (volume < 0 || volume > 100)
                throw new Exception("Громкость аудио не может быть больше 100");

            ManagedSocketResolver
                .SoundSocket[number]
                .Player
                .Volume = volume / 100f;
        }

        internal static int Sound_GetVolume(int number)
        {
            AssertSocketIsOpened(number);

            return (int)(ManagedSocketResolver
                .SoundSocket[number]
                .Player
                .Volume * 100);
        }

        internal static void Sound_Close(int number)
        {
            AssertSocketIsOpened(number);

            ManagedSocketResolver
                .SoundSocket
                .CloseSocket(number);
        }

        private static void AssertSoundSocketIsFree(int number)
        {
            if (ManagedSocketResolver.SoundSocket.IsSocketBusy(number))
            {
                throw new Exception($"Аудиофайл №{number} уже открыт");
            }
        }

        private static void AssertSocketIsOpened(int number)
        {
            if (!ManagedSocketResolver.SoundSocket.IsSocketBusy(number)
                || ManagedSocketResolver.SoundSocket[number].SocketState == Enums.SoundSocketState.None)
            {
                throw new Exception($"Аудиофайл №{number} не открыт");
            }
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
