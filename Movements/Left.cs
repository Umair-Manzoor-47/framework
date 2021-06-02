using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    public class Left : IMove
    {
        public void action(PictureBox character, int MovementSpeed)
        {
            character.Left += MovementSpeed;
        }

        MovementType IMove.getType()
        {
            return MovementType.Left;
        }
    }
}
