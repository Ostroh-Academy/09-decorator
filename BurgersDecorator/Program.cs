//Декоратор для системи бургерів з різними варіаціями
//Розробити декоратори для базового бургера, які додають інгредієнти та варіанти подачі,
//змінюючи ціну в залежності від додавань.

namespace BurgersDecorator;


public interface IBurger
{
    string Description { get; }
    double Cost { get; }
}


public class BasicBurger : IBurger
{
    public string Description => "Basic Burger";
    public double Cost => 5.00;
}


public abstract class BurgerDecorator : IBurger
{
    protected IBurger _burger;

    public BurgerDecorator(IBurger burger)
    {
        _burger = burger ?? throw new ArgumentNullException(nameof(burger));
    }

    public virtual string Description => _burger.Description;
    public virtual double Cost => _burger.Cost;
}


public class CheeseDecorator : BurgerDecorator
{
    public CheeseDecorator(IBurger burger) : base(burger) { }

    public override string Description => $"{_burger.Description}, Cheese";
    public override double Cost => _burger.Cost + 1.00;
}

public class BaconDecorator : BurgerDecorator
{
    public BaconDecorator(IBurger burger) : base(burger) { }

    public override string Description => $"{_burger.Description}, Bacon";
    public override double Cost => _burger.Cost + 1.50;
}

public class LettuceDecorator : BurgerDecorator
{
    public LettuceDecorator(IBurger burger) : base(burger) { }

    public override string Description => $"{_burger.Description}, Lettuce";
    public override double Cost => _burger.Cost + 0.75;
}

public class TomatoDecorator : BurgerDecorator
{
    public TomatoDecorator(IBurger burger) : base(burger) { }

    public override string Description => $"{_burger.Description}, Tomato";
    public override double Cost => _burger.Cost + 0.50;
}


public class DoublePattyDecorator : BurgerDecorator
{
    public DoublePattyDecorator(IBurger burger) : base(burger) { }

    public override string Description => $"{_burger.Description}, Double Patty";
    public override double Cost => _burger.Cost + 2.00;
}

public class GlutenFreeBunDecorator : BurgerDecorator
{
    public GlutenFreeBunDecorator(IBurger burger) : base(burger) { }

    public override string Description => $"{_burger.Description}, Gluten-Free Bun";
    public override double Cost => _burger.Cost + 1.25;
}


public class Client
{
    public void ShowBurgerDetails(IBurger burger)
    {
        Console.WriteLine($"Burger: {burger.Description}");
        Console.WriteLine($"Cost: ${burger.Cost:F2}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        // Creating a basic burger
        IBurger myBurger = new BasicBurger();
        client.ShowBurgerDetails(myBurger);
        Console.WriteLine();

        // Adding ingredients using a more flexible approach
        myBurger = AddDecorators(myBurger, new List<Func<IBurger, IBurger>>
        {
            burger => new CheeseDecorator(burger),
            burger => new BaconDecorator(burger),
            burger => new LettuceDecorator(burger),
            burger => new TomatoDecorator(burger),
            burger => new DoublePattyDecorator(burger),
            burger => new GlutenFreeBunDecorator(burger)
        });

        client.ShowBurgerDetails(myBurger);
    }

    static IBurger AddDecorators(IBurger burger, List<Func<IBurger, IBurger>> decorators)
    {
        foreach (var decorator in decorators)
        {
            burger = decorator(burger);
        }
        return burger;
    }
}

