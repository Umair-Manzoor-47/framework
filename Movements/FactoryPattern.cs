using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    public class FactoryPattern
    {


        public int[] objects = { 0, 0, 0, 0 };

        private FactoryPattern()
        {

        }

        // A private static instance of the same class
        private static FactoryPattern instance = null;

        public static FactoryPattern GetInstance()
        {
            // create the instance only if the instance is null
            if (instance == null)
            {
                instance = new FactoryPattern();
            }

            // Otherwise return the already existing instance
            return instance;
        }

        // default movement
        public gameObject createObj(Role role, PictureBox character, int speed)
        {
            // adding objects in gameObject class
            gameObject obj = new gameObject(character, speed, MovementType.Left);

            // count object
            objects[role.GetHashCode()] += 1;

            return obj;

        }



        // if movement is defined
        public gameObject createObj(Role role, PictureBox character, int speed, MovementType type)
        {
            // adding objects in gameObject class
            gameObject obj = new gameObject(character, speed, type);

            // saving is Game Class
            game Add = game.GetInstance();
            Add.addObject(obj);
            objects[role.GetHashCode()] += 1;

            return obj;
        }


        // getters
        public int getHeroCount()
        {

            return objects[0];
        }
        public int getEnemyCount()
        {
            return objects[1];
        }
        public int getCoinCount()
        {
            return objects[2];
        }
        public int getTotalCount()
        {
            return objects[0] + objects[1] + objects[2] + objects[3];
        }
    }
}

