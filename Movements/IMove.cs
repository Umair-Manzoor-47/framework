using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Movements
{
    public interface IMove
    {
        void action(PictureBox character, int MovementSpeed);

        MovementType getType();

    }
}
