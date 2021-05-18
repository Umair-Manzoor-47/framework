using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Gravity
{
    class Movement : Form
    {
    // this allows picture box to move under defined speed and gravity
    
        // speed
        int speed = 0;

        // Constructor
        public Movement(int fallSpeed)
        {
            speed = fallSpeed;
        }

        // method to allow objects fall
        public void fall(gameObject obj)

        {
            PictureBox character =  obj.getCharacter();
            character.Top += speed;
        }
        // we can add different movements here as move left or right
         public void left(gameObject obj)

        {
            PictureBox character =  obj.getCharacter();
            character.Left -= speed;
        }
        public void right(gameObject obj)

        {
            PictureBox character =  obj.getCharacter();
            character.Left += speed;
        }

    }
}
