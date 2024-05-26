namespace Lab9ju;

public class ShortcutMouseDriverDecorator : MouseDriverDecorator
{
    public ShortcutMouseDriverDecorator(IMouseDriver source) : base(source) { }

    public override void Click()
    {
        base.Click();
        // Тут можна додати обробку швидких команд.
    }

    public void ExecuteShortcut(string command)
    {
        Console.WriteLine($"Shortcut command '{command}' executed");
        // Додати логіку виконання швидких команд.
    }
}