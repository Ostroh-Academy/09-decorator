using Lab_09_Zahrebelnyi;

class Program
{
    static void Main(string[] args)
    {
        // Базовий будинок
        House house = new ConcreteHouse();
        Console.WriteLine($"{house.GetDescription()} costs {house.GetCost()}");

        // Будинок з басейном
        house = new PoolDecorator(house);
        Console.WriteLine($"{house.GetDescription()} costs {house.GetCost()}");

        // Будинок з басейном та гаражем
        house = new GarageDecorator(house);
        Console.WriteLine($"{house.GetDescription()} costs {house.GetCost()}");
    }
}