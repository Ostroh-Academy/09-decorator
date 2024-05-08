namespace _09_decorator_keroNight.Lab9;

public class BaseDataPackage : IDataPackage
{
    public void Send() => 
        Console.WriteLine("Відправлення базового пакету даних...");
}