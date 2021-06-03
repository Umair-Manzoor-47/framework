using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Movements
{
    public class Reverse : IImpact
    {
        List<PictureBox> pbOne = new List<PictureBox>();

        int speed;

        public Reverse(Role role,int speed)
        {
            game g = game.GetInstance();
            pbOne = g.getPb(role);
            this.speed = speed;
        }
        public void action()
        {
            foreach (PictureBox picture in pbOne)
            {
                picture.Top -= speed;
            }
        }
    }
}
