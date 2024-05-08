
// Concrete Components provide default implementations of the operations.
// There might be several variations of these classes.

// The base Decorator class follows the same interface as the other
// components. The primary purpose of this class is to define the wrapping
// interface for all concrete decorators. The default implementation of the
// wrapping code might include a field for storing a wrapped component and
// the means to initialize it.

// Concrete Decorators call the wrapped object and alter its result in some
// way.

// Decorators can execute their behavior either before or after the call to
// a wrapped object.

public class Client
{
    // The client code works with all objects using the Component interface.
    // This way it can stay independent of the concrete classes of
    // components it works with.
    public void ClientCode(Component component)
    {
        Console.WriteLine("RESULT: " + component.Operation());
    }
}
