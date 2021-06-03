using System;
using System.Collections.Generic;
using System.Linq;
using Movements;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace jet
{
    class gameLogic
    {

        // A private constructor to restrict the object creation from outside
        private gameLogic()
        {

        }

        // A private static instance of the same class
        private static gameLogic instance = null;

        public static gameLogic GetInstance()
        {
            // create the instance only if the instance is null
            if (instance == null)
            {
                instance = new gameLogic();
            }

            // Otherwise return the already existing instance
            return instance;
        }

        public ArrayList gameObjects = new ArrayList();

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
