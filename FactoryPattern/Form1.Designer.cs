
namespace Movements
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.coin = new System.Windows.Forms.PictureBox();
            this.mainGameTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemiesCount = new System.Windows.Forms.Label();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.CoinsCount = new System.Windows.Forms.Label();
            this.TotalObjects = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::Movements.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(130, 12);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(46, 41);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // hero
            // 
            this.hero.Image = global::Movements.Properties.Resources.hero;
            this.hero.Location = new System.Drawing.Point(211, 389);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(67, 49);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hero.TabIndex = 1;
            this.hero.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::Movements.Properties.Resources.enemy;
            this.enemyTwo.Location = new System.Drawing.Point(269, 12);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(46, 41);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyTwo.TabIndex = 2;
            this.enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::Movements.Properties.Resources.enemy;
            this.enemyThree.Location = new System.Drawing.Point(441, 12);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(46, 41);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyThree.TabIndex = 3;
            this.enemyThree.TabStop = false;
            // 
            // coin
            // 
            this.coin.Image = global::Movements.Properties.Resources.coin;
            this.coin.Location = new System.Drawing.Point(533, 420);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(34, 31);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coin.TabIndex = 4;
            this.coin.TabStop = false;
            // 
            // mainGameTimer
            // 
            this.mainGameTimer.Enabled = true;
            this.mainGameTimer.Interval = 20;
            this.mainGameTimer.Tick += new System.EventHandler(this.timer);
            // 
            // EnemiesCount
            // 
            this.EnemiesCount.AutoSize = true;
            this.EnemiesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemiesCount.Location = new System.Drawing.Point(649, 9);
            this.EnemiesCount.Name = "EnemiesCount";
            this.EnemiesCount.Size = new System.Drawing.Size(95, 24);
            this.EnemiesCount.TabIndex = 5;
            this.EnemiesCount.Text = "Enemies :";
            // 
            // PlayerCount
            // 
            this.PlayerCount.AutoSize = true;
            this.PlayerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCount.Location = new System.Drawing.Point(12, 404);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(81, 24);
            this.PlayerCount.TabIndex = 6;
            this.PlayerCount.Text = "Players :";
            // 
            // CoinsCount
            // 
            this.CoinsCount.AutoSize = true;
            this.CoinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinsCount.Location = new System.Drawing.Point(12, 12);
            this.CoinsCount.Name = "CoinsCount";
            this.CoinsCount.Size = new System.Drawing.Size(68, 24);
            this.CoinsCount.TabIndex = 7;
            this.CoinsCount.Text = "Coins :";
            // 
            // TotalObjects
            // 
            this.TotalObjects.AutoSize = true;
            this.TotalObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalObjects.Location = new System.Drawing.Point(12, 190);
            this.TotalObjects.Name = "TotalObjects";
            this.TotalObjects.Size = new System.Drawing.Size(130, 24);
            this.TotalObjects.TabIndex = 8;
            this.TotalObjects.Text = "Total Objects :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalObjects);
            this.Controls.Add(this.CoinsCount);
            this.Controls.Add(this.PlayerCount);
            this.Controls.Add(this.EnemiesCount);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.enemyOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Timer mainGameTimer;
        private System.Windows.Forms.Label EnemiesCount;
        private System.Windows.Forms.Label PlayerCount;
        private System.Windows.Forms.Label CoinsCount;
        private System.Windows.Forms.Label TotalObjects;
    }
}

