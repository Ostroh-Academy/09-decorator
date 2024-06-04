namespace Lab_09_Zahrebelnyi
{
	public class GarlandDecorator : TreeDecorator
	{
		public GarlandDecorator(ChristmasTree tree) : base(tree) { }

		public override string GetDescription()
		{
			return base.GetDescription() + ", with garlands";
		}

		public override double GetCost()
		{
			return base.GetCost() + 15; // додаткові витрати на гірлянди
		}
	}
}