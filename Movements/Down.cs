using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movements
{
    class Down : Move
    {
        public void action(PictureBox character, int MovementSpeed)
        {
            character.Top += MovementSpeed;
        }
    }
}
