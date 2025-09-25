using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Const;
using System.Reflection.PortableExecutable;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (CoffeeType type in Enum.GetValues(typeof(CoffeeType)))
            {
                Beverage beverage = CoffeeFactory.MakeCoffee(type);
                PrintBeverage(beverage);
            }
        }


        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.SizeCost().ToString("#.##"));
        }
    }
}