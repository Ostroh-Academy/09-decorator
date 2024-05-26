namespace Lab9ju;

public class StandardMouseDriver : IMouseDriver
{
    public void Move(int x, int y)
    {
        Console.WriteLine($"Mouse moved to ({x}, {y})");
    }

    public void Click()
    {
        Console.WriteLine("Left click performed");
    }

    public void RightClick()
    {
        Console.WriteLine("Right click performed");
    }
}