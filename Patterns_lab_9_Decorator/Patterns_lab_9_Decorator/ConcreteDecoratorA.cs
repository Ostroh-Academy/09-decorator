
// Concrete Components provide default implementations of the operations.
// There might be several variations of these classes.

// The base Decorator class follows the same interface as the other
// components. The primary purpose of this class is to define the wrapping
// interface for all concrete decorators. The default implementation of the
// wrapping code might include a field for storing a wrapped component and
// the means to initialize it.

// Concrete Decorators call the wrapped object and alter its result in some
// way.
class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(Component comp) : base(comp)
    {
    }

    // Decorators may call parent implementation of the operation, instead
    // of calling the wrapped object directly. This approach simplifies
    // extension of decorator classes.
    public override string Operation()
    {
        return $"ConcreteDecoratorA({base.Operation()})";
    }
}
