﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El gato dice miau");
        }
    }
}
