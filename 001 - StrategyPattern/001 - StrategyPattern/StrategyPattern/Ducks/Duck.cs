using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected SpeakBehavior speakBehavior;
        protected FlyBehavior flyBehavior;
        protected SwimBehaviour swimbehaviour;
        public abstract void Display();
        public void PerformSpeak()
        {
            speakBehavior.Speak();
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformSwim()
        {
            swimbehaviour.Swim();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
