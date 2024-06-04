namespace Lab_09_Zahrebelnyi
{
    public class OrnamentDecorator : TreeDecorator
    {
        public OrnamentDecorator(ChristmasTree tree) : base(tree) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with ornaments";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10; // додаткові витрати на іграшки
        }
    }
}