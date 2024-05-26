namespace Lab9ju;

public class GestureMouseDriverDecorator : MouseDriverDecorator
{
    public GestureMouseDriverDecorator(IMouseDriver source) : base(source) { }

    public override void Move(int x, int y)
    {
        base.Move(x, y);
        // Тут можна додати обробку жестів.
    }

    public void PerformGesture(string gesture)
    {
        Console.WriteLine($"Gesture '{gesture}' performed");
        // Додати логіку виконання жестів.
    }
}