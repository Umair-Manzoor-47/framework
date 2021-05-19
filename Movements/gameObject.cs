using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading.Tasks;

namespace Movements
{
    class gameObject
    {
        // pictureBoxes as character
        PictureBox character;
        // speed
        int speed;
        // movement class
        Move obj;
        public gameObject() // null constructor
        {

        }

        public gameObject(PictureBox character, int speed, Move go) // constructor overloading
        {
            this.character = character;
            this.speed = speed;
            obj = go;
        }

        public void Update(){

            obj.action(this.character, this.speed);

        }
        

    }
}
