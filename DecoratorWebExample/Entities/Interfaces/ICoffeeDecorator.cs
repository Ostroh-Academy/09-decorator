namespace DecoratorWebExample.Entities.Interfaces;

public interface ICoffeeDecorator : ICoffee
{
    ICoffee Coffee { get; }
}