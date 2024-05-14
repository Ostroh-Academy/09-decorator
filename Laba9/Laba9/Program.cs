using Laba9;

class Program
{
    static void Main(string[] args)
    {
        IGraphicComponent component = new BaseGraphicComponent();
        component = new ShadowDecorator(component);
        component = new GradientDecorator(component);
        component.Draw();

        Console.ReadLine();
    }
}
