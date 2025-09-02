using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck RobotDuck = new RobotDuck();

            TestDuck(mallardDuck);
            TestDuck(redheadDuck);
            TestDuck(decoyDuck);
            TestDuck(rubberDuck);
            TestDuck(RobotDuck);
        }

        private static void TestDuck(Duck duck)
        {
            Console.WriteLine("\nTesting: " + duck.GetType().Name);
            duck.Display();
            duck.PerformSpeak();
            duck.PerformFly();
            duck.PerformSwim();
        }
    }
}