namespace Laba9.Models;

class ArmorDecorator : CarDecorator
{
    public ArmorDecorator(ICar decoratedCar) : base(decoratedCar) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Armored";
    }

    public override double GetCost()
    {
        return base.GetCost() + 5000;
    }
}