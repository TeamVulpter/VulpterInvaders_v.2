﻿namespace Game
{
    using System;
    using System.Windows.Forms;
    using Classes;
    using Classes.Characters;
    using Classes.Items;
    using Classes.Matrix;
    using System.Collections.Generic;
    using System.Drawing;

    public partial class VulpterInvadersGame : Form
    {
        private Player player;
        private Item item;
        private IList<Bonus> bonus;
        private Brick bricks;
        private IList<Brick> bricksList = new List<Brick>();
        private Map matrix = new Map();
        private int[,] playField;
        private ObsticleBrick obsticle;

        public VulpterInvadersGame()
        {
            InitializeComponent();
            this.player = new Player(350, 560, hero);
            this.obsticle=new ObsticleBrick(300,50,Obsticle);
            try
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
                //drawing matrix
                this.playField = this.matrix.DrawField();
                //drawing bricks
                this.bricksList.Add(new Brick(brick.Location.X, brick.Location.Y, brick));
                this.bricksList.Add(new Brick(brick1.Location.X, brick1.Location.Y, brick1));
                //this.item = new Item(300, 300, ItemType.Brick);
                ////generation on bonuses
                //this.bonus.Add(new Bonus(100, 100, ItemType.BonusLife));


            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var br in bricksList)
            {
                if (br.BrickSingle.Location.X == player.Hero.Left && br.BrickSingle.Location.Y == player.Hero.Top &&
                    br.BrickSingle.Bounds.Height == player.Hero.Bounds.Height)
                {
                    br.BrickSingle.Visible = false;
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //moving hero
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.player.PositionX = hero.Location.X;
            this.player.PositionY = hero.Location.Y;

            if (e.KeyCode == Keys.W)
            {
                hero.Location = new Point(player.PositionX, player.PositionY - 10);
            }
            if (e.KeyCode == Keys.S)
            {
                hero.Location = new Point(player.PositionX, player.PositionY + 10);
            }
            if (e.KeyCode == Keys.A)
            {
                hero.Location = new Point(player.PositionX - 10, player.PositionY);
            }
            if (e.KeyCode == Keys.D)
            {
                hero.Location = new Point(player.PositionX + 10, player.PositionY);
            }
            if (e.KeyCode == Keys.X)
            {
                InvadersAttack invaderAttack = new InvadersAttack();
                this.Close();
                invaderAttack.Show();
            }

        }

        ////button for start
        //private void start_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("");
        //}

        ////button for create hero
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //this.player = new Player(0, 0, "Arthur");
        //    MessageBox.Show("Create");
        //}

        private void hero_Click(object sender, EventArgs e)
        {

        }

        private void ObsticleTimer_Tick(object sender, EventArgs e)
        {
            this.obsticle.PositionX = Obsticle.Location.X;
            this.obsticle.PositionY = Obsticle.Location.Y;

            Obsticle.Location=new Point(obsticle.PositionX +1, obsticle.PositionY);

            if (obsticle.PositionY>=brick1.Location.Y)
            {
                if (Obsticle.Right >= brick15.Left)
                {
                    Obsticle.Location=new Point(brick1.Location.X-1,brick1.Location.Y);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
