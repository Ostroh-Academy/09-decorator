using System;

public interface IFactory
{
    void Produce();
}

// виробляє цивільне обладнання
public class CivilFactory : IFactory
{
    public void Produce()
    {
        Console.WriteLine("Producing civil equipment...");
    }
}

// Декоратор, який додає можливість виробляти військове обладнання
public class MilitaryDecorator : IFactory
{
    private readonly IFactory _factory;

    public MilitaryDecorator(IFactory factory)
    {
        _factory = factory;
    }

    public void Produce()
    {
        _factory.Produce();
        Console.WriteLine("Producing military equipment...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFactory civilFactory = new CivilFactory();

        IFactory militaryFactory = new MilitaryDecorator(civilFactory);

        
        civilFactory.Produce(); 
        Console.WriteLine();
        militaryFactory.Produce(); 

        Console.ReadKey();
    }
}
