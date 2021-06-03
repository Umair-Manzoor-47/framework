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
            obj.collisions();


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

                gameObject obj1 = factory.createObj(Role.hero, hero, 3, MovementType.MoveWithKey);
                gameObject obj2 = factory.createObj(Role.enemy, enemyOne, 1, MovementType.Down); // default behaviour
                gameObject obj3 = factory.createObj(Role.enemy, enemyTwo, 1, MovementType.Down);
                gameObject obj4 = factory.createObj(Role.enemy, enemyThree, 1, MovementType.Down);
                gameObject obj5 = factory.createObj(Role.coin, coin, 1, MovementType.Down);

                CollisionDetection C = new CollisionDetection(Role.hero, Role.enemy, new ReduceHealth(Hp, 1));
                CollisionDetection D = new CollisionDetection(Role.hero, Role.coin, new IncreaseHealth(Hp, 1));
                CollisionDetection E = new CollisionDetection(Role.hero, Role.coin, new Reverse(Role.coin, 2));


            // saving is Game Class

            obj.addObject(obj1);
            obj.addObject(obj2);
            obj.addObject(obj3);
            obj.addObject(obj4);
            obj.addObject(obj5);
            obj.addCollision(C);
            obj.addCollision(D);
            obj.addCollision(E);

            // No of objects
            PlayerCount.Text = "Players : " + factory.getHeroCount();
                EnemiesCount.Text = "Enemy : " + factory.getEnemyCount();
                // CoinsCount.Text = "Coins : " + factory.getCoinCount();
                TotalObjects.Text = "Total Objects : " + factory.getTotalCount();
            
        }
    }
}

