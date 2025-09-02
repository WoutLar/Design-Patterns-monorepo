using StrategyPattern.Interfaces.FlyBehavior.FlyImplementations;
using StrategyPattern.Interfaces.QuackBehavior.SpeakImplementations;
using StrategyPattern.Interfaces.SwimBehavior.SwimImplimentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            speakBehavior = new Quack();
            flyBehavior = new FlyWithWings();
            swimbehaviour = new Swimming();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
