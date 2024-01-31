using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {

        // fields
        private string description;
        private CollectionBoard board;

        // properties
        public string Description { get { return description; } set { description = value; } }
        public CollectionBoard Board { get { return board; } set { board = value; } }

        // adds collectable to list and prints collected message
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(description + " Collected, Congrats!!!!");
        }

        // abstract Display method
        public abstract void Display();

    }
}
