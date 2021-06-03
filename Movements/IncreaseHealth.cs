using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Threading.Tasks;

namespace Movements
{
    public class IncreaseHealth : IImpact
    {
        private ProgressBar hp;
        private int increment;
        public IncreaseHealth(ProgressBar hp, int increment)
        {
            this.hp = hp;
            this.increment = increment;
        }
        public void action()
        {
            if (hp.Value < 100)
            {
                this.hp.Value += increment;

            }
            
        }
    }
}
