﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject.DesignPatterns.Structural.Facade
{
    public class PizzaProvider : IPizza
    {
        public void GetPizza()
        {
            Console.WriteLine("Get Pizza");
        }
    }
}