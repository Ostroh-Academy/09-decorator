namespace Lab9ju;

// Програма може різним шляхом збирати об'єкти, які декоруються залежно від умов використання.
public class Program
{
    public static void Main(string[] args)
    {
        IMouseDriver mouseDriver = new StandardMouseDriver();

        // Приклад декорування драйвера мишки.
        mouseDriver = new GestureMouseDriverDecorator(mouseDriver);
        mouseDriver = new ShortcutMouseDriverDecorator(mouseDriver);

        // Використання декорованого драйвера.
        mouseDriver.Move(100, 200);
        mouseDriver.Click();
        mouseDriver.RightClick();

        // Використання нових функцій декораторів.
        ((GestureMouseDriverDecorator)mouseDriver).PerformGesture("Swipe Up");
        ((ShortcutMouseDriverDecorator)mouseDriver).ExecuteShortcut("Copy");
    }
}