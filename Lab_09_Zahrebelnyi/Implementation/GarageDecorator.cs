namespace Lab_09_Zahrebelnyi
{
    public class GarageDecorator : HouseDecorator
    {
        public GarageDecorator(House house) : base(house) { }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with a garage";
        }

        public override double GetCost()
        {
            return base.GetCost() + 4000; // додаткові витрати на гараж
        }
    }
}