using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimer(object sender, EventArgs e)
        {
           update();

        }


        // this method will decide speed of falling object and which object to fall under gravity as well
        public void update()
        {
            Movement obj = new Movement(3);
            gameObject player = new gameObject(hero);
            gameObject enemy_1 = new gameObject(enemyOne);
            gameObject enemy_2 = new gameObject(enemyTwo);
            obj.fall(player);
            obj.fall(enemy_1);
            obj.fall(enemy_2);
        }
    }
}
