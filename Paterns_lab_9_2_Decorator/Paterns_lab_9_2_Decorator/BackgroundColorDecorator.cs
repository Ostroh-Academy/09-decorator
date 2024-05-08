
// Декоратор, що додає іконку до кнопки.

// Декоратор, що змінює шрифт на похилий.

// Декоратор, що змінює колір фону кнопки.
class BackgroundColorDecorator : IButton
{
    private IButton button;

    public BackgroundColorDecorator(IButton button)
    {
        this.button = button;
    }

    public void Render()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        button.Render();
        Console.ResetColor();
    }
}
