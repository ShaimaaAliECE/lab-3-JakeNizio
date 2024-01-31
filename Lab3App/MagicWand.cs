using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool
    {
        // constructor
        public MagicWand(string name)
        {
            Description = name;
        }

        // overridden DoAction, prints the action messaged
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        // overridden Display, prints the display message
        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }

    }
}
