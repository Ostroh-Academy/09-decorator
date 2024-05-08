namespace _09_decorator_keroNight.MyExample;

public class SugarDecorator : IBeverage 
{
    private IBeverage _beverage;

    public SugarDecorator(IBeverage beverage) => 
        _beverage = beverage;

    public string GetDescription() => 
        _beverage.GetDescription() + ", з цукром";

    public double Cost() => 
        _beverage.Cost() + 0.2;
}