namespace Laba9.Models;

abstract class CarDecorator : ICar
{
    protected ICar decoratedCar;

    public CarDecorator(ICar decoratedCar)
    {
        this.decoratedCar = decoratedCar;
    }

    public virtual string GetDescription()
    {
        return decoratedCar.GetDescription();
    }

    public virtual double GetCost()
    {
        return decoratedCar.GetCost();
    }
}