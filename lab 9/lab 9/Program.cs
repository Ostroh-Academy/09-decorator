using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Замовляємо каву з молоком та цукром
            Beverage coffeeWithMilkAndSugar = new SugarDecorator(new MilkDecorator(new Coffee()));

            // Виводимо опис та ціну напою
            Console.WriteLine("Напій: " + coffeeWithMilkAndSugar.Description);
            Console.WriteLine("Ціна: $" + coffeeWithMilkAndSugar.Cost());
            Console.ReadKey();
        }
    }
}
