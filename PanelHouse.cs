﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
