using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool
    {

        // constructor
        public Axe(string name)
        {
            Description = name;
        }

        // overridden DoAction, prints the action messaged
        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }

        // overridden Display, prints the display message
        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

    }
}
