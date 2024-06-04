using System;
namespace lab_9
{
    public class SimpleAudioFile : IAudioFile
    {
        private string fileName;

        public SimpleAudioFile(string fileName)
        {
            this.fileName = fileName;
        }

        public void Play()
        {
            Console.WriteLine($"Playing {fileName}...");
        }
    }
}

