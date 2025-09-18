using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System.Reflection.PortableExecutable;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            Beverage Doppio = new Espresso();
            Doppio = new Espresso(espresso);
            PrintBeverage(Doppio);

            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            Beverage Macchiato = new Espresso();
            Macchiato = new MilkFoam(Macchiato);
            PrintBeverage(Macchiato);

            Beverage Cappucinno = new Espresso();
            Cappucinno = new SteamedMilk(Cappucinno);
            Cappucinno = new MilkFoam(Cappucinno);
            PrintBeverage(Cappucinno);

            Beverage corretta = new Espresso();
            corretta = new Liqour(corretta);
            PrintBeverage(corretta);

            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            Beverage cappuccino = new Espresso();
            cappuccino = new SteamedMilk(cappuccino);
            cappuccino = new MilkFoam(cappuccino);
            PrintBeverage(cappuccino);

            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);

            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            PrintBeverage(romana);

            Beverage morocchino = new Espresso();
            morocchino = new ChocolateCondument(morocchino);
            morocchino = new MilkFoam(morocchino);
            PrintBeverage(morocchino);

            Beverage mocha = new Espresso();
            mocha = new ChocolateCondument(mocha);
            mocha = new SteamedMilk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            Beverage bicerin = new Espresso();
            bicerin = new BlackChocolate(bicerin);
            bicerin = new WhiteChocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            Beverage breve = new Espresso();
            breve = new MilkFoam(breve);
            breve = new HalfMilk(breve);
            PrintBeverage(breve);

            Beverage rafCoffee = new Espresso();
            rafCoffee = new Vanilla(rafCoffee);
            rafCoffee = new Sugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            Beverage galao = new Espresso();
            galao = new MilkFoam(galao);
            galao = new MilkFoam(galao);
            PrintBeverage(galao);

            Beverage affogato = new Espresso();
            affogato = new Espresso(affogato);
            affogato = new IceCream(affogato);
            PrintBeverage(affogato);

            Beverage vienna = new Espresso();
            vienna = new Espresso(vienna);
            vienna = new Whip(vienna);
            vienna = new Whip(vienna);
            PrintBeverage(vienna);

            Beverage glace = new Espresso();
            glace = new IceCream(glace);
            PrintBeverage(glace);

            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            Beverage demiCreme = new Espresso();
            demiCreme = new Espresso(demiCreme);
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new SteamedMilk(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new SteamedMilk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCream(frappe);
            PrintBeverage(frappe);

            Beverage irishCoffee = new Espresso();
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);

            Beverage TallEspresso = new Espresso();
            TallEspresso.Size = Size.TALL;
            PrintBeverage(TallEspresso);

            Beverage GrandeEspresso = new Espresso();
            GrandeEspresso.Size = Size.GRANDE;
            PrintBeverage(GrandeEspresso);

            Beverage VendiEspresso = new Espresso();
            VendiEspresso.Size = Size.VENDI;
            PrintBeverage(VendiEspresso);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" +  beverage.SizeCost().ToString("#.##"));
        }
    }
}