using _9._14.Burgers;
using _9._14.Decorators;

namespace _9._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger myBurger = new BasicBurger();
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");

            myBurger = new CheeseDecorator(myBurger);
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");

            myBurger = new BaconDecorator(myBurger);
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");

            myBurger = new LettuceDecorator(myBurger);
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");

            myBurger = new TomatoDecorator(myBurger);
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");

            myBurger = new DoubleBurgerDecorator(myBurger);
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");

            myBurger = new ComboMealDecorator(myBurger);
            Console.WriteLine($"{myBurger.GetDescription()} - ${myBurger.GetCost()}");
        }
    }
}
