using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    class Up : Move
    {
        public override void action(PictureBox character, int MovementSpeed)
        {
            character.Top -= MovementSpeed;
        }
    }
}
