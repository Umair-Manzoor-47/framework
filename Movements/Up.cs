using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    public class Up : IMove
    {
        // void constructor
        internal Up(){  }
        public void action(PictureBox character, int MovementSpeed)
        {
            character.Top -= MovementSpeed;
        }
        MovementType IMove.getType()
        {
            return MovementType.Up;
        }
    }
}
