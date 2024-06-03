using System;

// Базовий інтерфейс драйвера мишки
public interface IMouseDriver
{
    void Click();
    void DoubleClick();
    void Scroll(int direction);
}

// Реалізація стандартного драйвера мишки
public class StandardMouseDriver : IMouseDriver
{
    public void Click()
    {
        Console.WriteLine("Виконано клік мишкою");
    }

    public void DoubleClick()
    {
        Console.WriteLine("Виконано подвійний клік мишкою");
    }

    public void Scroll(int direction)
    {
        Console.WriteLine($"Прокручено мишкою у напрямку {direction}");
    }
}

// Базовий клас декоратора
public abstract class MouseDriverDecorator : IMouseDriver
{
    protected IMouseDriver _mouseDriver;

    public MouseDriverDecorator(IMouseDriver mouseDriver)
    {
        _mouseDriver = mouseDriver;
    }

    public virtual void Click()
    {
        _mouseDriver.Click();
    }

    public virtual void DoubleClick()
    {
        _mouseDriver.DoubleClick();
    }

    public virtual void Scroll(int direction)
    {
        _mouseDriver.Scroll(direction);
    }
}

// Декоратор, що додає можливість виконувати кастомні жести
public class GestureMouseDriverDecorator : MouseDriverDecorator
{
    public GestureMouseDriverDecorator(IMouseDriver mouseDriver) : base(mouseDriver)
    {
    }

    public void PerformGesture(string gesture)
    {
        Console.WriteLine($"Виконано жест мишкою: {gesture}");
    }
}

// Декоратор, що додає можливість виконувати швидкі команди
public class SpeedCommandMouseDriverDecorator : MouseDriverDecorator
{
    public SpeedCommandMouseDriverDecorator(IMouseDriver mouseDriver) : base(mouseDriver)
    {
    }

    public void ExecuteCommand(string command)
    {
        Console.WriteLine($"Виконана швидка команда мишкою: {command}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення стандартного драйвера мишки
        IMouseDriver standardMouseDriver = new StandardMouseDriver();
        Console.WriteLine("Використання стандартного драйвера мишки:");
        standardMouseDriver.Click();
        standardMouseDriver.DoubleClick();
        standardMouseDriver.Scroll(1);

        // Додавання декоратора з новою функцією кастомних жестів до стандартного драйвера мишки
        IMouseDriver gestureMouseDriver = new GestureMouseDriverDecorator(standardMouseDriver);
        Console.WriteLine("\nВикористання декоратора для додавання кастомних жестів:");
        gestureMouseDriver.Click();
        gestureMouseDriver.DoubleClick();
        gestureMouseDriver.Scroll(-1);
        ((GestureMouseDriverDecorator)gestureMouseDriver).PerformGesture("Swipe Left");

        // Додавання декоратора з новою функцією швидких команд до стандартного драйвера мишки
        IMouseDriver speedCommandMouseDriver = new SpeedCommandMouseDriverDecorator(standardMouseDriver);
        Console.WriteLine("\nВикористання декоратора для додавання швидких команд:");
        speedCommandMouseDriver.Click();
        speedCommandMouseDriver.DoubleClick();
        speedCommandMouseDriver.Scroll(1);
        ((SpeedCommandMouseDriverDecorator)speedCommandMouseDriver).ExecuteCommand("Copy");
    }
}
