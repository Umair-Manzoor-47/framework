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
       
        ObjectFactory objectFactory = ObjectFactory.GetInstance();

        /* in case there are more movements we can make an arrayList here
         * and save objects and call action methods in update function */

        internal gameObject(PictureBox character, int speed, MovementType type) // constructor
        {
            this.character = character;
            this.speed = speed;
            
            obj = objectFactory.getMovementType(type); 
        }

        public void Update() // update movement
        {

            obj.action(this.character, this.speed);
        }  

    }
}
