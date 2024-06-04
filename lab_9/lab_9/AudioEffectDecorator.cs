using System;
namespace lab_9
{
    public abstract class AudioEffectDecorator : IAudioFile
    {
        protected IAudioFile audioFile;

        public AudioEffectDecorator(IAudioFile audioFile)
        {
            this.audioFile = audioFile;
        }

        public virtual void Play()
        {
            audioFile.Play();
        }
    }
}

