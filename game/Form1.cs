using System;
using Movements;
using System.Windows.Forms;

namespace jet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // factory object
        FactoryPattern factory = FactoryPattern.GetInstance();

        // game Object 
        game obj;


        // object to update key status
        MoveWithKey movement = new MoveWithKey();

        

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

        private void Form1_Load_1(object sender, EventArgs e)
        {            
                obj = game.GetInstance();

                gameObject obj1 = factory.createObj(Role.hero, hero, 3, new MoveWithKey());
                gameObject obj2 = factory.createObj(Role.enemy, enemyOne, 3, new Down()); // default behaviour
                gameObject obj3 = factory.createObj(Role.enemy, enemyTwo, 2, new Down());
                gameObject obj4 = factory.createObj(Role.enemy, enemyThree, 2, new Down());
                gameObject obj5 = factory.createObj(Role.coin, coin, 2, new Down());




                // saving is Game Class

                obj.addObject(obj1);
                obj.addObject(obj2);
                obj.addObject(obj3);
                obj.addObject(obj4);
                obj.addObject(obj5);

                // No of objects
                PlayerCount.Text = "Players : " + factory.getHeroCount();
                EnemiesCount.Text = "Enemy : " + factory.getEnemyCount();
                // CoinsCount.Text = "Coins : " + factory.getCoinCount();
                TotalObjects.Text = "Total Objects : " + factory.getTotalCount();
            
        }
    }
}

