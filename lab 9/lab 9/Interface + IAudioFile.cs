using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    // Базовий інтерфейс аудіофайлу
    interface IAudioFile
    {
        void Play();
    }

    // Конкретний клас аудіофайлу
    class ConcreteAudioFile : IAudioFile
    {
        private string filename;

        public ConcreteAudioFile(string filename)
        {
            this.filename = filename;
        }

        public void Play()
        {
            Console.WriteLine($"Playing audio file: {filename}");
        }
    }
}