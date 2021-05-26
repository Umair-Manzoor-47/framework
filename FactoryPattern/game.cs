using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{

    class game
    {

        // A private constructor to restrict the object creation from outside
        private game()
        {

        }

        // A private static instance of the same class
        private static game instance = null;

        public static game GetInstance()
        {
            // create the instance only if the instance is null
            if (instance == null)
            {
                instance = new game();
            }

            // Otherwise return the already existing instance
            return instance;
        }

        public ArrayList gameObjects = new ArrayList();
        //public game()
        //{

        //}
        public void addObject(gameObject gameObj)
        {
            gameObjects.Add(gameObj);
            
        }
        public void update()
        {

            foreach (gameObject go in gameObjects)
            {

                go.Update();

            }
        }

    }
}