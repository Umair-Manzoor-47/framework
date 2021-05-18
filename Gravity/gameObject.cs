using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Gravity
{
    class gameObject : Form
    {
        PictureBox character = new PictureBox();
        public gameObject(PictureBox obj)
        {
            character = obj;
        }
        public PictureBox getCharacter()
        {
            return this.character;
        }
        

    }
}
