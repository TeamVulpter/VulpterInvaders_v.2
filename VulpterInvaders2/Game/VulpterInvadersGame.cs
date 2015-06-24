namespace Game
{
    using System;
    using System.Windows.Forms;
    using Classes;
    using Classes.Characters;
    using Classes.Items;
    using Classes.Factory;
    using Classes.Matrix;
    using System.Collections.Generic;
    using System.Drawing;

    public partial class VulpterInvadersGame : Form
    {
        private Player player;
        private Item item;
        private Brick bricks;
        private IList<Brick> bricksList = new List<Brick>();
        private Map matrix = new Map();
        private int[,] playField;
        private ObsticleBrick obsticle;
        private ObsticleBrick obsticle2;
        private ObsticleBrick obsticle3;
        private ObsticleBrick obsticle4;
        private ObsticleBrick obsticle5;
        private IList<ObsticleBrick> obsticles=new List<ObsticleBrick>();
        private IList<Item> items = new List<Item>(); 
 

        public VulpterInvadersGame()
        {
            InitializeComponent();
            //create player
            this.player = new Player(350, 560, hero);
            this.obsticle=new ObsticleBrick(67,401,Obsticle);
            this.obsticle2 = new ObsticleBrick(67, 339, Obsticle2);
            this.obsticle3 = new ObsticleBrick(67, 243, Obsticle3);
            this.obsticle4 = new ObsticleBrick(67, 153, Obsticle4);
            this.obsticle5 = new ObsticleBrick(67, 53, Obsticle5);
            obsticles.Add(obsticle);
            obsticles.Add(obsticle2);
            obsticles.Add(obsticle3);
            obsticles.Add(obsticle4);
            obsticles.Add(obsticle5);
            try
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
                //drawing matrix
                this.playField = this.matrix.DrawField();
                //drawing bricks
                this.bricksList.Add(new Brick(brick.Location.X, brick.Location.Y, brick));
                this.bricksList.Add(new Brick(brick1.Location.X, brick1.Location.Y, brick1));

                //generation items with bonus
                ItemsFactory itemsFactory = new ItemsFactory();
                items = itemsFactory.CreateItems(10);

            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                int top = this.brick16.Location.Y + this.brick16.Height;
                hero.Location = player.PositionY >= top ? 
                    new Point(player.PositionX, player.PositionY - 5) : 
                    new Point(player.PositionX, player.PositionY + 5);
            }
            if (e.KeyCode == Keys.S)
            {
                int down = this.brick6.Location.Y-hero.Width;
                hero.Location = this.player.PositionY <= down ? 
                    new Point(player.PositionX, player.PositionY + 5) : 
                    new Point(player.PositionX, player.PositionY - 5);
            }
            if (e.KeyCode == Keys.A)
            {
                int left = this.brick1.Location.X + this.brick1.Width;
                hero.Location = this.player.PositionX >= left ? 
                    new Point(player.PositionX - 5, player.PositionY) : 
                    new Point(player.PositionX + 5, player.PositionY);
                
            }
            if (e.KeyCode == Keys.D)
            {
                int right = this.brick11.Location.X-hero.Height;
                hero.Location = this.player.PositionX <= right ? 
                    new Point(player.PositionX + 5, player.PositionY) : 
                    new Point(player.PositionX - 5, player.PositionY);
            }
            if (e.KeyCode == Keys.X)
            {
                InvadersAttack invaderAttack = new InvadersAttack();
                this.Close();
                invaderAttack.Show();
            }

        }
        
        private void hero_Click(object sender, EventArgs e)
        {

        }

        private void ObsticleTimer_Tick(object sender, EventArgs e)
        {
            this.obsticle.PositionX = Obsticle.Location.X;
            this.obsticle.PositionY = Obsticle.Location.Y;

            this.obsticle2.PositionX = Obsticle2.Location.X;
            this.obsticle2.PositionY = Obsticle2.Location.Y;

            this.obsticle3.PositionX = Obsticle3.Location.X;
            this.obsticle3.PositionY = Obsticle3.Location.Y;

            this.obsticle4.PositionX = Obsticle4.Location.X;
            this.obsticle4.PositionY = Obsticle4.Location.Y;

            this.obsticle5.PositionX = Obsticle5.Location.X;
            this.obsticle5.PositionY = Obsticle5.Location.Y;



            Obsticle.Location=new Point(obsticle.PositionX +1 , obsticle.PositionY);
            Obsticle2.Location = new Point(obsticle2.PositionX - 1, obsticle2.PositionY);
            Obsticle3.Location = new Point(obsticle3.PositionX +1, obsticle3.PositionY);
            Obsticle4.Location = new Point(obsticle4.PositionX + 1, obsticle4.PositionY);
            Obsticle5.Location = new Point(obsticle5.PositionX + 1, obsticle5.PositionY);

            if (obsticle.PositionY>=brick5.Location.Y-1)
            {
                if (Obsticle.Right >= brick11.Left)
                {
                    Obsticle.Location=new Point(brick5.Location.X-1,brick5.Location.Y);
                }
            }

            bool obsticleOne = (
                                    Obsticle.Location.X + Obsticle.Width >= this.player.Hero.Location.X &&
                                    Obsticle.Location.X <= this.player.Hero.Left
                               ) &&
                               (
                                    Obsticle.Location.Y >= this.player.Hero.Top &&
                                    Obsticle.Location.Y <= this.player.Hero.Top + this.player.Hero.Height
                               );

            if (obsticleOne)
            {
                Obsticle.Location = new Point(brick5.Location.X - 1, brick5.Location.Y);
                Life.LifeCount--;
                life_value.Text = Life.LifeCount.ToString();
                if (Life.LifeCount == 0)
                {
                    MessageBox.Show("Game over");
                    Application.Exit();
                }
            }

            //obsticle2 movement
            if (obsticle2.PositionY >= brick4.Location.Y - 1)
            {
                if (Obsticle2.Left <= brick4.Right)
                {
                    Obsticle2.Location = new Point(brick12.Location.X + 1, brick12.Location.Y);
                }
            }
            // Obsticle3 movement
            if (obsticle3.PositionY >= brick13.Location.Y - 1)
            {
                if (Obsticle3.Right >= brick13.Left)
                {
                    Obsticle3.Location = new Point(brick3.Location.X - 1, brick3.Location.Y);
                }
            }
            /// Obsticle4 movement
            if (obsticle4.PositionY >= brick14.Location.Y - 1)
            {
                if (Obsticle4.Right >= brick14.Left)
                {
                    Obsticle4.Location = new Point(brick2.Location.X - 1, brick2.Location.Y);
                }
            }
            //Obsticle5 movement
            if (obsticle5.PositionY >= brick15.Location.Y - 1)
            {
                if (Obsticle5.Right >= brick15.Left)
                {
                    Obsticle5.Location = new Point(brick1.Location.X - 1, brick1.Location.Y);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Obsticle3_Click(object sender, EventArgs e)
        {

        }
    }
}
