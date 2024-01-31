using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        // overridden AddMe, calls the base AddMe and then calls DoAction
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }

        // prints the action message
        public abstract void DoAction();

    }
}
