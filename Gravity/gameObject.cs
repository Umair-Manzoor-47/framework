using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Gravity
{
    //class for every character
    class gameObject
    {
        // pictureBoxes as character
        PictureBox character;
        public gameObject() // null constructor
        {
            
        }
        
        public gameObject(PictureBox character) // constructor overloading
        {
            this.character = character;
        }
        
        // return pictureBox
        public PictureBox getCharacter()
        {
            return this.character;
        }

    }
}
