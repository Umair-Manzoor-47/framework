using System;

using System.Windows.Forms;

namespace Movements
{
    public class gameObject
    {
        // pictureBoxes as character
        PictureBox character;
        // speed
        int speed;
        // movement class
        IMove obj;

        /* in case there are more movements we can make an arrayList here
         * and save objects and call action methods in update function */

        internal gameObject(PictureBox character, int speed, IMove go) // constructor
        {
            this.character = character;
            this.speed = speed;
            obj = go;
        }

        public void Update() // update movement
        {

            obj.action(this.character, this.speed);
        }  

    }
}
