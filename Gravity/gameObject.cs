using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Gravity
{
    // this class creats individual objects for characters in game
    
    class gameObject : Form
    {
        PictureBox character = new PictureBox();
        public gameObject(PictureBox obj)
        {
            character = obj;
        }
        
        // getting picture box for various actions
        
        public PictureBox getCharacter()
        {
            return this.character;
        }
        

    }
}
