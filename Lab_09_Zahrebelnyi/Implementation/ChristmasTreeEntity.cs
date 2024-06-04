namespace Lab_09_Zahrebelnyi
{
    public class ChristmasTreeEntity : ChristmasTree
    {
        public override string GetDescription()
        {
            return "Christmas Tree";
        }

        public override double GetCost()
        {
            return 30; // базова вартість ялинки
        }
    }
}