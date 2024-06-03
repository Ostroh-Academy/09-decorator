using _9._14.Burgers;

namespace _9._14.Decorators
{
    public class ComboMealDecorator : BurgerDecorator
    {
        public ComboMealDecorator(Burger burger) : base(burger) { }

        public override double GetCost()
        {
            return _burger.GetCost() + 3.00; 
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + " Combo Meal";
        }
    }
}
