namespace Lab_09_Zahrebelnyi
{
	public abstract class HouseDecorator : House
	{
		protected House _house;

		public HouseDecorator(House house)
		{
			_house = house;
		}

		public override string GetDescription()
		{
			return _house.GetDescription();
		}

		public override double GetCost()
		{
			return _house.GetCost();
		}
	}
}