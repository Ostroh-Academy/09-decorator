namespace Lab_09_Zahrebelnyi
{
    public class ConcreteHouse : House
    {
        public override string GetDescription()
        {
            return "Concrete house";
        }

        public override double GetCost()
        {
            return 20000; // базова вартість будинку
        }
    }
}