
// Декоратор, що додає іконку до кнопки.

// Декоратор, що змінює шрифт на похилий.
class ItalicFontDecorator : IButton
{
    private IButton button;

    public ItalicFontDecorator(IButton button)
    {
        this.button = button;
    }

    public void Render()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        button.Render();
        Console.ResetColor();
    }
}
