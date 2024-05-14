namespace Laba9.Models;

class BasicTruck : ICar
{
    public string GetDescription()
    {
        return "Basic Truck";
    }

    public double GetCost()
    {
        return 20000;
    }
}