﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб2
{
    public class Kva : Pry
    {
        public Kva(double a)
        {
            Shi = a;
            Vis = a;
        }
        public override string ToString()
        {
            return ($"Квадрат. Площадь {Plo()}.");
        }
    }
}
