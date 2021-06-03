using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movements
{   
    public class Right : IMove
    {
        // null constructor
        internal Right() { }

        public void action(PictureBox character, int MovementSpeed)
        {
            character.Left -= MovementSpeed;
        }
        MovementType IMove.getType()
        {
            return MovementType.Right;
        }
    }
}
