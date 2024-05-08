
// Декоратор, що додає іконку до кнопки.
class IconDecorator : IButton
{
    private IButton button;
    private string icon;

    public IconDecorator(IButton button, string icon)
    {
        this.button = button;
        this.icon = icon;
    }

    public void Render()
    {
        button.Render();
        Console.WriteLine($"Icon: {icon}");
    }
}
