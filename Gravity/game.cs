using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Gravity
{
    // class providing basic actions
    class game
    {
        // speed
        int speed;

        // static arrayList
        public static ArrayList gameObjects = new ArrayList();

        // consctructor
        public game(int speed)
        {
            this.speed = speed;
        }

        //adding in arrayList
        public void addObject(gameObject obj)
        {
            gameObjects.Add(obj);
        }
        public void update()
        {
            gameObject g_obj = new gameObject();
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObject obj = (gameObject)gameObjects[i];
                PictureBox box = obj.getCharacter();
                gravity(box);

            }
            
        }

        // method to allow free fall
        private void gravity(PictureBox character)
        {
            character.Top += speed;
        }
        
    }
}
