using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {

        // fields
        private int score;

        // properties
        public int Score { get { return score; } set { score = value; } }

        // updates the TotalScore field in CollectionBoard
        public void UpdateTotalScore()
        {
            Board.TotalScore += score;
        }

        // overridden AddMe, calls the base AddMe, calls UpdateTotalScore and then prints the updated TotalScore
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalScore();
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

    }
}
