using System;

interface IButton
{
    void Draw();
}

// Реалізація базової кнопки
class Button : IButton
{
    private string _text;

    public Button(string text)
    {
        _text = text;
    }

    public void Draw()
    {
        Console.WriteLine($"Drawing button with text: {_text}");
    }
}

// Базовий декоратор
abstract class ButtonDecorator : IButton
{
    protected IButton _button;

    public ButtonDecorator(IButton button)
    {
        _button = button;
    }

    public virtual void Draw()
    {
        _button.Draw();
    }
}

// Декоратор для додавання іконки до кнопки
class IconButtonDecorator : ButtonDecorator
{
    private string _icon;

    public IconButtonDecorator(IButton button, string icon) : base(button)
    {
        _icon = icon;
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"Adding icon: {_icon}");
    }
}

// Декоратор для зміни шрифту на похилий
class ItalicFontDecorator : ButtonDecorator
{
    public ItalicFontDecorator(IButton button) : base(button)
    {
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Changing font to italic.");
    }
}

// Декоратор для зміни кольору фону
class BackgroundColorDecorator : ButtonDecorator
{
    private string _color;

    public BackgroundColorDecorator(IButton button, string color) : base(button)
    {
        _color = color;
    }

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"Changing background color to: {_color}");
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        IButton button = new Button("Click me");

 
        button = new IconButtonDecorator(button, "icon.png");
        button = new ItalicFontDecorator(button);

        button.Draw();

        button = new BackgroundColorDecorator(button, "blue");

        button.Draw();
    }
}

