namespace _09_decorator_keroNight;

public class Coffee : IBeverage 
{
    public string GetDescription() => "Кава";

    public double Cost() => 1.0;
}