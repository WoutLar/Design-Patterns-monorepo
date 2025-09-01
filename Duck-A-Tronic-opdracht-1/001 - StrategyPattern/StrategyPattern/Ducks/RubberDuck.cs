using StrategyPattern.Interfaces.FlyBehavior.FlyImplementations;
using StrategyPattern.Interfaces.QuackBehavior.SpeakImplementations;
using StrategyPattern.Interfaces.QuackBehavior.SpeakImplimentations;
using StrategyPattern.Interfaces.SwimBehavior.SwimImplimentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            speakBehavior = new Squeak();
            flyBehavior = new NoFly();
            swimbehaviour = new Swimming();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
