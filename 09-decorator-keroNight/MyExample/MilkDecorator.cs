namespace _09_decorator_keroNight.MyExample;

public class MilkDecorator: IBeverage 
{
    private IBeverage _beverage;

    public MilkDecorator(IBeverage beverage) => 
        _beverage = beverage;

    public string GetDescription() => 
        _beverage.GetDescription() + ", з молоком";

    public double Cost() => 
        _beverage.Cost() + 0.5;
}