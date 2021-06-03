using System;

using System.Windows.Forms;

namespace Movements
{
    public class gameObject
    {
        Role role;
        // pictureBoxes as character
        PictureBox character;
        // speed
        int speed;
        // movement class
        IMove obj;
       
        ObjectFactory objectFactory = ObjectFactory.GetInstance();

        /* in case there are more movements we can make an arrayList here
         * and save objects and call action methods in update function */

        internal gameObject(Role role, PictureBox character, int speed, MovementType type) // constructor
        {
            this.role = role;
            this.character = character;
            this.speed = speed;
            
            obj = objectFactory.getMovementType(type); 
        }

        public void Update() // update movement
        {

            obj.action(this.character, this.speed);
        }        
        public Role getRole()
        {
            return this.role;
        }
        public PictureBox getPb()
        {
            return this.character;
        }
    }
}
