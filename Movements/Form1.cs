using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // game Object
        game obj;

       // object to update key status
        MoveWithKey movement = new MoveWithKey();

        private void Form1_Load(object sender, EventArgs e)
        {

            // adding objects in gameObject class
            gameObject player = new gameObject(hero, 3, new MoveWithKey()); // 'new Left()' is a child class object 
            gameObject enemy_1 = new gameObject(enemyOne, 3, new Left());
            gameObject enemy_2 = new gameObject(enemyTwo, 2, new Down());
            gameObject enemy_3 = new gameObject(enemyThree, 2, new Right());
            gameObject incentive = new gameObject(coin, 2, new Up());

            obj = game.GetInstance();
            obj.addObject(player);
            obj.addObject(enemy_1);
            obj.addObject(enemy_2);
            obj.addObject(enemy_3);
            obj.addObject(incentive);


        }

        // tick Event of timer
        private void timer(object sender, EventArgs e)
        {
            obj.update();
        }

        // movement Key pressed event
        private void keyisDown(object sender, KeyEventArgs e)
        {            
            movement.keyisdown(e);
        }

        // movement Key relased event
        private void keyisUp(object sender, KeyEventArgs e)
        {
            movement.keyisup(e);
        }
    }
}
