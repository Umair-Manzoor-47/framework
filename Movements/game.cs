using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{

    public class game
    {
        private List<Grid> Grid;


        // A private constructor to restrict the object creation from outside
        private game()
        {
            Grid = new List<Grid>();
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

        private ArrayList gameObjects = new ArrayList();
        List<CollisionDetection> collisions = new List<CollisionDetection>();

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
        public void addGrid(int tileWidth, int tileHeight, Form gameForm, string filePath, string imagesFolderPath)
        {
            Grid grid = new Grid(tileWidth, tileHeight, gameForm, filePath, imagesFolderPath);
            Grid.Add(grid);
            grid.addTilesToGrid();
        }
        public void addCollision(CollisionDetection collision)
        {
            collisions.Add(collision);

        }
        public void collision()
        {
            foreach(CollisionDetection collision in collisions)
            {
                collision.update();
            }
        }
        public List<PictureBox> getPb(Role role)
        {
            List<PictureBox> pictureboxes = new List<PictureBox>();
            PictureBox picture;

            foreach (gameObject go in gameObjects)
            {
                if (role == go.getRole())
                {
                    picture = go.getPb();
                    pictureboxes.Add(picture);
                }
                
            }
            return pictureboxes;
        }
        //public void addCollision(CollisionDetection collision, IImpact impact)
        //{
        //    collisions.Add(collision);
        //    impacts.Add(impact);


        //}

    }
}