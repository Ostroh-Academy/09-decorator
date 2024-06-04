namespace Lab_09_Zahrebelnyi
{
    public class LedLightsDecorator : TreeDecorator
    {
        public LedLightsDecorator(ChristmasTree tree) : base(tree) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with LED lights";
        }

        public override double GetCost()
        {
            return base.GetCost() + 20; // додаткові витрати на гірлянди
        }
    }
}