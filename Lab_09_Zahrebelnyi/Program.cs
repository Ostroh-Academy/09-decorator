using Lab_09_Zahrebelnyi;

class Program
{
    static void Main(string[] args)
    {
        // Базова ялинка
        ChristmasTree tree = new ChristmasTreeEntity();
        Console.WriteLine($"{tree.GetDescription()} costs {tree.GetCost()}");

        // Ялинка з іграшками
        tree = new OrnamentDecorator(tree);
        Console.WriteLine($"{tree.GetDescription()} costs {tree.GetCost()}");

        // Ялинка з іграшками та гірляндами
        tree = new GarlandDecorator(tree);
        Console.WriteLine($"{tree.GetDescription()} costs {tree.GetCost()}");

        // Ялинка з іграшками, гірляндами та світлодіодними гірляндами
        tree = new LedLightsDecorator(tree);
        Console.WriteLine($"{tree.GetDescription()} costs {tree.GetCost()}");
    }
}