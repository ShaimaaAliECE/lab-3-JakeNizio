using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond : Treasure
    {

        
        // constructor
        public Diamond(string name, int score)
        {
            Description = name;
            Score = score;
        }

        // overridden Display, prints the display message
        public override void Display()
        {
            Console.WriteLine("Diamond " + Description + " is displayed");

        }

    }
}
