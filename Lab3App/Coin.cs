using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {

        // fields
        private int val;

        // properties
        public int Value { get { return val; } set { val = value; } }

        // constructor
        public Coin(string name, int score, int value)
        {
            Description = name;
            Score = score;
            val = value;
        }

        // updates the TotalValue field in CollectionBoard
        public void UpdateTotalValue()
        {
            Board.TotalValue += val;
        }

        // overridden AddMe, calls the base AddMe, calls UpdateTotalValue and then prints the updated TotalValue
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        // overridden Display, prints the display message
        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }


    }
}
