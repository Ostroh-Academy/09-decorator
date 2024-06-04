using System;
namespace lab_9
{
    public class ReverbDecorator : AudioEffectDecorator
    {
        public ReverbDecorator(IAudioFile audioFile) : base(audioFile) { }

        public override void Play()
        {
            base.Play();
            ApplyReverb();
        }

        private void ApplyReverb()
        {
            Console.WriteLine("Applying reverb effect...");
        }
    }
}

