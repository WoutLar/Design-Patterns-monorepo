﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior.SwimImplimentations
{
    internal class Swimming : SwimBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("I am Swimming!");
        }
    }
   }
