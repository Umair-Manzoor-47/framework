using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movements
{
    class MoveWithKey: Move
    {
        
        // boolean variables
        static bool goLeft, goRight, goUp, goDown;
        public void action(PictureBox character, int MovementSpeed)
        {
            // character movement logic starts

            if (goLeft == true)
            {
                character.Left -=  MovementSpeed;
            }
            if (goRight == true)
            {
                character.Left +=  MovementSpeed;
            }
            if (goUp == true)
            {
                character.Top -=  MovementSpeed;
            }
            if (goDown == true)
            {
                character.Top +=  MovementSpeed;
            }

            // character movement logic ends
        }
        public void keyisdown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }
        public void keyisup(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
    }
}
