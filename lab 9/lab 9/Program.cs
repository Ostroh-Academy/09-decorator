using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створення базового аудіофайлу
            IAudioFile audioFile = new ConcreteAudioFile("music.mp3");

            // Додавання ефекту реверберації
            audioFile = new ReverbDecorator(audioFile);

            // Додавання ефекту ехо
            audioFile = new EchoDecorator(audioFile);

            // Відтворення аудіофайлу з ефектами
            audioFile.Play();
            Console.ReadLine();
        }
    }
}