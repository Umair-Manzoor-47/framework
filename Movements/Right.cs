using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movements
{
    class Right : Move
    {
        public override void action(PictureBox character, int MovementSpeed)
        {
            character.Left -= MovementSpeed;
        }
    }
}
