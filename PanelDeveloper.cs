using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
