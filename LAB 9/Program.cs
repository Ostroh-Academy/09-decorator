using LAB_9;

class Program
{
    static void Main(string[] args)
    {
        IButton button = new SimpleButton("Натиснiть");
        button.Render();

        button = new IconButtonDecorator(button);
        button.Render();

        button = new ItalicButtonDecorator(button);
        button.Render();

        button = new ColorButtonDecorator(button);
        button.Render();

        Console.ReadLine();
    }
}