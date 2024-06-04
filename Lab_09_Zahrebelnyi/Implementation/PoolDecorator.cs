namespace Lab_09_Zahrebelnyi
{
    public class PoolDecorator : HouseDecorator
    {
        public PoolDecorator(House house) : base(house) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with a pool";
        }

        public override double GetCost()
        {
            return base.GetCost() + 5000; // додаткові витрати на басейн
        }
    }
}