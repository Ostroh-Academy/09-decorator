using System;
namespace lab_9
{
    public class EchoDecorator : AudioEffectDecorator
    {
        public EchoDecorator(IAudioFile audioFile) : base(audioFile) { }

        public override void Play()
        {
            base.Play();
            ApplyEcho();
        }

        private void ApplyEcho()
        {
            Console.WriteLine("Applying echo effect...");
        }
    }
}

