using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior.SpeakImplementations
{
    internal class Quack : SpeakBehavior
    {
        public void Speak() 
        {
            Console.WriteLine("Quack");
        }
    }
}
