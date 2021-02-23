using BMVE.Core.Enums;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMVE.Core.Utils.Utils
{
    internal class SoundSocket
    {
        internal string Filename;

        internal SoundSocketState SocketState = SoundSocketState.None;

        internal AudioFormat AudioFormat = AudioFormat.Mp3;

        internal WaveOut Player = new WaveOut();

        internal MemoryStream Stream;

        internal WaveStream Reader;


    }
}
