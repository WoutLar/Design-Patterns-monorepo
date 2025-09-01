using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior.SpeakImplimentations
{
    internal class Squeak : SpeakBehavior
    {
        public void Speak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
