using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movements
{
    public class Down : IMove
    {
        public void action(PictureBox character, int MovementSpeed)
        {
            character.Top += MovementSpeed;
        }
        MovementType IMove.getType()
        {
            return MovementType.Down;
        }
    }
}
