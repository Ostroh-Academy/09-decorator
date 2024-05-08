using _09_decorator_keroNight;

IBeverage beverage = new Coffee();

beverage = new MilkDecorator(beverage);
beverage = new SugarDecorator(beverage);

Console.WriteLine("Напій: " + beverage.GetDescription());
Console.WriteLine("Вартість: $" + beverage.Cost());