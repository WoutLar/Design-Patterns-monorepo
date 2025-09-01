using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.FlyBehavior.FlyImplementations
{
    internal class NoFly : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("i cant fly");
        }
    }
}
