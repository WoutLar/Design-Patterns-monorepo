using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Const;

internal abstract class CoffeeFactory
{
    internal abstract Beverage MakeCoffee(CoffeeType type);

    internal void PrintBeverage(Beverage beverage)
    {
        Console.WriteLine(beverage.GetDescription() + " $" + beverage.SizeCost().ToString("#.##"));
    }
}
