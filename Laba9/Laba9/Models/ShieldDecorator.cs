namespace Laba9.Models;

class ShieldDecorator : CarDecorator
{
    public ShieldDecorator(ICar decoratedCar) : base(decoratedCar) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Shield";
    }

    public override double GetCost()
    {
        return base.GetCost() + 3000; // Додаткова вартість за захисний щит
    }
}