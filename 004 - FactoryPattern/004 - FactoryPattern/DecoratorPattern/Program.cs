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
            CoffeeFactory factory = new CafeWoedroeIncFactory();

            foreach (CoffeeType type in Enum.GetValues(typeof(CoffeeType)))
            {
                Beverage beverage = factory.MakeCoffee(type);
                factory.PrintBeverage(beverage);
            }
        }
    }
}