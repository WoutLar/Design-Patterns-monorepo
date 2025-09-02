using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.QuackBehavior.SpeakImplimentations
{
    internal class MetalicScreach : SpeakBehavior
    {
        public void Speak()
        {
            Console.WriteLine("Dead or alive, you're coming with me");
        }

    }
}
