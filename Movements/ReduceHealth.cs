using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    public class ReduceHealth : IImpact
    {
        private ProgressBar hp;
        private int reduction;
        public ReduceHealth(ProgressBar hp, int reduction)
        {
            this.hp = hp;
            this.reduction = reduction;
        }
        public void action()
        {
            if(hp.Value > 0) 
            { 
                this.hp.Value -= reduction;
        
            }   
    
        }
    }
}
