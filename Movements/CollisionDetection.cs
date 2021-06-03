using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    public class CollisionDetection
    {
        // lists for two types of gameobjects 
        List<PictureBox> pbOne = new List<PictureBox>();
        List<PictureBox> pbTwo = new List<PictureBox>();

        // impact
        IImpact impact;

        game G = game.GetInstance();
        // 
        public CollisionDetection(Role roleOne, Role roleTwo, IImpact impact)
        {
            
            this.impact = impact;
            reterivePB(roleOne, roleTwo);
        }
        private void reterivePB(Role roleOne, Role roleTwo)
        {
            game G = game.GetInstance();
            pbOne = G.getPb(roleOne);
            pbTwo = G.getPb(roleTwo);
        }
        private bool detect(PictureBox pictureOne, PictureBox pictureTwo)
        {
            
           
            if (pictureOne.Bounds.IntersectsWith(pictureTwo.Bounds))
            {
                return true;
            }
                return false;
        }
        public void update()
        {
            foreach (PictureBox pictureOne in pbOne) 
            {
                foreach (PictureBox pictureTwo in pbTwo)
                {
                    bool collided = detect(pictureOne, pictureTwo);
                    if (collided)
                    {
                        impact.action();
                    }
                }

            }
        }
    }
}
