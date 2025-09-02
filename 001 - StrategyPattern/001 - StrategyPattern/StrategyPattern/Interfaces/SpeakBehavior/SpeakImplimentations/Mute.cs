using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior.SpeakImplimentations
{
    internal class Mute : SpeakBehavior
    {
        public void Speak()
        {
            Console.WriteLine("<<Silence>>");
        }

    }
}
