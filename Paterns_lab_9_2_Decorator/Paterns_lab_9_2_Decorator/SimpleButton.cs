class SimpleButton : IButton
{
    private string text;

    public SimpleButton(string text)
    {
        this.text = text;
    }

    public void Render()
    {
        Console.WriteLine($"Simple Button: {text}");
    }
}
