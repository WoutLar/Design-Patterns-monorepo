using StrategyPattern.Interfaces.FlyBehavior.FlyImplementations;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior.SpeakImplementations;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior.SwimImplimentations;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.QuackBehavior.SpeakImplimentations;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck() 
        {
            speakBehavior = new MetalicScreach();
            flyBehavior = new FlyWithRocket();
            swimbehaviour = new Sink();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a ROBOT Duck");
        }
    }
}
