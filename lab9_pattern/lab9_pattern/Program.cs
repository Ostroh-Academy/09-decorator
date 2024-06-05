using System;
abstract class Textile
{
    public abstract string GetDescription();
    public abstract double GetPrice();
}
class TShirt : Textile
{
    public override string GetDescription()
    {
        return "Футболка";
    }

    public override double GetPrice()
    {
        return 20.0;
    }
}
abstract class EmbroideryDecorator : Textile
{
    protected Textile textile;

    public EmbroideryDecorator(Textile textile)
    {
        this.textile = textile;
    }

    public override string GetDescription()
    {
        return textile.GetDescription();
    }

    public override double GetPrice()
    {
        return textile.GetPrice();
    }
}
class FloralEmbroidery : EmbroideryDecorator
{
    public FloralEmbroidery(Textile textile) : base(textile)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", з вишивкою рослинним орнаментом";
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 10.0;
    }
}
class AnimalEmbroidery : EmbroideryDecorator
{
    public AnimalEmbroidery(Textile textile) : base(textile)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", з вишивкою тваринними мотивами";
    }

    public override double GetPrice()
    {
        return base.GetPrice() + 15.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Textile tShirt = new TShirt();
        Console.WriteLine("Опис: {0}", tShirt.GetDescription());
        Console.WriteLine("Ціна: {0} грн", tShirt.GetPrice());

        Textile floralTShirt = new FloralEmbroidery(tShirt);
        Console.WriteLine("\nОпис: {0}", floralTShirt.GetDescription());
        Console.WriteLine("Ціна: {0} грн", floralTShirt.GetPrice());

        Textile animalTShirt = new AnimalEmbroidery(tShirt);
        Console.WriteLine("\nОпис: {0}", animalTShirt.GetDescription());
        Console.WriteLine("Ціна: {0} грн", animalTShirt.GetPrice());

        Textile floralAnimalTShirt = new AnimalEmbroidery(new FloralEmbroidery(tShirt));
        Console.WriteLine("\nОпис: {0}", floralAnimalTShirt.GetDescription());
        Console.WriteLine("Ціна: {0} грн", floralAnimalTShirt.GetPrice());
    }
}
