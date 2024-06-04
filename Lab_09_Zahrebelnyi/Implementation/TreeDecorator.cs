namespace Lab_09_Zahrebelnyi
{
	public abstract class TreeDecorator : ChristmasTree
	{
		protected ChristmasTree _tree;

		public TreeDecorator(ChristmasTree tree)
		{
			_tree = tree;
		}

		public override string GetDescription()
		{
			return _tree.GetDescription();
		}

		public override double GetCost()
		{
			return _tree.GetCost();
		}
	}
}