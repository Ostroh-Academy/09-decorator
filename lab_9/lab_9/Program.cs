using lab_9;

class Program
{
    static void Main(string[] args)
    {
        // Створення простого аудіофайлу
        IAudioFile audioFile = new SimpleAudioFile("song.mp3");

        // Додавання реверберації
        audioFile = new ReverbDecorator(audioFile);

        // Додавання ехо
        audioFile = new EchoDecorator(audioFile);

        // Відтворення аудіофайлу з ефектами
        audioFile.Play();

        // Вихід з програми
        Console.ReadKey();
    }
}