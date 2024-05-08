using _09_decorator_keroNight.Lab9;
using _09_decorator_keroNight.MyExample;

Console.WriteLine("Оберіть приклад (1 - Приклад з напоєм, 2 - По завданю варіанту 12):");
var choice = Console.ReadLine();

if (choice == "1") 
{
    IBeverage beverage = new Coffee();

    beverage = new MilkDecorator(beverage);
    beverage = new SugarDecorator(beverage);

    Console.WriteLine("Напій: " + beverage.GetDescription());
    Console.WriteLine("Вартість: $" + beverage.Cost());
} 
else
{
    IDataPackage dataPackage = new BaseDataPackage();

    dataPackage = new ChecksumDecorator(dataPackage);

    dataPackage.Send();
}

