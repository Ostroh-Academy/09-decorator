namespace ConsoleApp1;

internal abstract class Decorator(Component component) : Component
{
    protected Component Component = component;

    public void SetComponent(Component component)
    {
        this.Component = component;
    }

    public override string Operation()
    {
        if (this.Component != null)
        {
            return this.Component.Operation();
        }

        return string.Empty;
    }
}