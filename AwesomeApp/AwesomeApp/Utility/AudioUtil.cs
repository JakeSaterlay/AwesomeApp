using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AwesomeApp.Utility
{
    public static class AudioUtil
    {
        public static void PlayAudio(string fileName)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("AwesomeApp.Audio." + fileName);
            var audio = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            audio.Load(audioStream);
            audio.Play();
        }
    }
}
