using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Const;

public static class CoffeeFactory
{
    internal static Beverage MakeCoffee(CoffeeType type)
    {
        Beverage beverage = new Espresso();

        switch (type)
        {
            case CoffeeType.Espresso:
                return beverage;

            case CoffeeType.Doppio:
                return new Espresso(beverage);

            case CoffeeType.Lungo:
                return new Water(beverage);

            case CoffeeType.Macchiato:
                return new MilkFoam(beverage);

            case CoffeeType.Cappuccino:
                beverage = new SteamedMilk(beverage);
                return new MilkFoam(beverage);

            case CoffeeType.Corretto:
                return new Liqour(beverage);

            case CoffeeType.ConPanna:
                return new Whip(beverage);

            case CoffeeType.Americano:
                beverage = new Water(beverage);
                return new Water(beverage);

            case CoffeeType.CaffeLatte:
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                return new MilkFoam(beverage);

            case CoffeeType.FlatWhite:
                beverage = new SteamedMilk(beverage);
                return new SteamedMilk(beverage);

            case CoffeeType.Romana:
                return new Lemon(beverage);

            case CoffeeType.Marocchino:
                beverage = new ChocolateCondument(beverage);
                return new MilkFoam(beverage);

            case CoffeeType.Mocha:
                beverage = new ChocolateCondument(beverage);
                beverage = new SteamedMilk(beverage);
                return new Whip(beverage);

            case CoffeeType.Bicerin:
                beverage = new BlackChocolate(beverage);
                beverage = new WhiteChocolate(beverage);
                return new Whip(beverage);

            case CoffeeType.Breve:
                beverage = new MilkFoam(beverage);
                return new HalfMilk(beverage);

            case CoffeeType.RafCoffee:
                beverage = new Vanilla(beverage);
                beverage = new Sugar(beverage);
                return new Cream(beverage);

            case CoffeeType.MeadRaf:
                beverage = new Honey(beverage);
                return new Cream(beverage);

            case CoffeeType.Galao:
                beverage = new MilkFoam(beverage);
                return new MilkFoam(beverage);

            case CoffeeType.Affogato:
                beverage = new Espresso(beverage);
                return new IceCream(beverage);

            case CoffeeType.Vienna:
                beverage = new Espresso(beverage);
                beverage = new Whip(beverage);
                return new Whip(beverage);

            case CoffeeType.Glace:
                return new IceCream(beverage);

            case CoffeeType.ChocolateMilk:
                beverage = new Chocolate();
                beverage = new Milk(beverage);
                return new Milk(beverage);

            case CoffeeType.DemiCreme:
                beverage = new Espresso(beverage);
                beverage = new Cream(beverage);
                return new Cream(beverage);

            case CoffeeType.LatteMacchiato:
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                return new MilkFoam(beverage);

            case CoffeeType.Freddo:
                beverage = new Liqour(beverage);
                return new Ice(beverage);

            case CoffeeType.Frappuccino:
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                return new Whip(beverage);

            case CoffeeType.CaramelFrappuccino:
                beverage = new Ice(beverage);
                beverage = new SteamedMilk(beverage);
                beverage = new Cream(beverage);
                return new Syrup(beverage);

            case CoffeeType.Frappe:
                beverage = new SteamedMilk(beverage);
                beverage = new SteamedMilk(beverage);
                return new IceCream(beverage);

            case CoffeeType.IrishCoffee:
                beverage = new Espresso(beverage);
                beverage = new Whiskey(beverage);
                return new Whip(beverage);

            case CoffeeType.TallEspresso:
                beverage.Size = Size.TALL;
                return beverage;

            case CoffeeType.GrandeEspresso:
                beverage.Size = Size.GRANDE;
                return beverage;

            case CoffeeType.VendiEspresso:
                beverage.Size = Size.VENDI;
                return beverage;

            default:
                throw new ArgumentException("Wat noem jij mij???");
        }
    }
}
