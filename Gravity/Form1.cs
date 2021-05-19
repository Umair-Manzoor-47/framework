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
        // creating object
        game obj;
        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimer(object sender, EventArgs e)
        {
            // Allow objects to free fall
            obj.update();

        }

        // form load event
        private void Form1_Load(object sender, EventArgs e)
        {

            // decide speed 
            obj = new game(5);

            // adding objects in gameObject class
            gameObject player = new gameObject(hero);
            gameObject enemy_1 = new gameObject(enemyOne);
            gameObject enemy_2 = new gameObject(enemyTwo);

            // saving in array for further actions 
            obj.addObject(player);
            obj.addObject(enemy_1);
            obj.addObject(enemy_2);
        }
    }
}
