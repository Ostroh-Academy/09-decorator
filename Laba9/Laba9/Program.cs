using Laba9.Models;

ICar basicTruck = new BasicTruck();
Console.WriteLine("Basic Truck Description: " + basicTruck.GetDescription());
Console.WriteLine("Basic Truck Cost: $" + basicTruck.GetCost());

Console.WriteLine();

ICar armoredTruck = new ArmorDecorator(basicTruck);
Console.WriteLine("Armored Truck Description: " + armoredTruck.GetDescription());
Console.WriteLine("Armored Truck Cost: $" + armoredTruck.GetCost());

Console.WriteLine();

ICar armoredTruckWithShield = new ShieldDecorator(new ArmorDecorator(basicTruck));
Console.WriteLine("Armored Truck with Shield Description: " + armoredTruckWithShield.GetDescription());
Console.WriteLine("Armored Truck with Shield Cost: $" + armoredTruckWithShield.GetCost());