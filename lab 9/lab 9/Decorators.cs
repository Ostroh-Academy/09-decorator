using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{

    // Декоратор для додавання ефектів до аудіофайлів
    abstract class AudioDecorator : IAudioFile
    {
        protected IAudioFile audioFile;

        public AudioDecorator(IAudioFile audioFile)
        {
            this.audioFile = audioFile;
        }

        public virtual void Play()
        {
            audioFile.Play();
        }
    }

    // Конкретний декоратор, що додає реверберацію до аудіофайлу
    class ReverbDecorator : AudioDecorator
    {
        public ReverbDecorator(IAudioFile audioFile) : base(audioFile) { }

        public override void Play()
        {
            base.Play();
            Console.WriteLine("Adding reverb effect...");
        }
    }

    // Конкретний декоратор, що додає ехо до аудіофайлу
    class EchoDecorator : AudioDecorator
    {
        public EchoDecorator(IAudioFile audioFile) : base(audioFile) { }

        public override void Play()
        {
            base.Play();
            Console.WriteLine("Adding echo effect...");
        }
    }
}