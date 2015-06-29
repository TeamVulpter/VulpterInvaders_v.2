using Game.Classes;

namespace Game
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    using Classes.Brick;
    using Classes.Characters;
    using Classes.Factory;
    using Classes.Items;
    using Classes.Map;

    using Exception;

    using Interfaces;

    public partial class VulpterInvadersGame : Form
    {
        private readonly IMap map;
        private readonly Player player;
        private IList<Brick> bricksList = new List<Brick>();
        private ObsticleBrick obsticle;
        private ObsticleBrick obsticle2;
        private ObsticleBrick obsticle3;
        private ObsticleBrick obsticle4;
        private ObsticleBrick obsticle5;
        private IList<ObsticleBrick> obsticles=new List<ObsticleBrick>();
        private IList<Item> items = new List<Item>(); 
        private List<PictureBox> itemsPictureBox = new List<PictureBox>(); 
        
        public VulpterInvadersGame()
        {
            InitializeComponent();
            try
            {
                //generation map coordinates
                this.map = new Map(this.brick16.Location.Y + this.brick16.Height,
                    this.brick6.Location.Y,
                    this.brick1.Location.X + this.brick1.Width,
                    this.brick11.Location.X);

                //create player
                this.player = new Player(((this.map.Right - this.map.Left)/2), this.map.Down - hero.Height, hero);

                //add item to list of items
                this.AddItemToList();

                //generation items with bonus
                ItemsFactory itemsFactory = new ItemsFactory();
                items = itemsFactory.CreateItems(11, itemsPictureBox, this.map);

                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
                //drawing bricks
                this.bricksList.Add(new Brick(brick.Location.X, brick.Location.Y, brick));
                this.bricksList.Add(new Brick(brick1.Location.X, brick1.Location.Y, brick1));
                this.bricksList.Add(new Brick(brick2.Location.X, brick2.Location.Y, brick2));
                this.bricksList.Add(new Brick(brick3.Location.X, brick3.Location.Y, brick3));
                this.bricksList.Add(new Brick(brick4.Location.X, brick4.Location.Y, brick4));
                this.bricksList.Add(new Brick(brick5.Location.X, brick5.Location.Y, brick5));
                this.bricksList.Add(new Brick(brick6.Location.X, brick6.Location.Y, brick6));
                this.bricksList.Add(new Brick(brick7.Location.X, brick7.Location.Y, brick7));
                this.bricksList.Add(new Brick(brick8.Location.X, brick8.Location.Y, brick8));
                this.bricksList.Add(new Brick(brick9.Location.X, brick9.Location.Y, brick9));
                this.bricksList.Add(new Brick(brick10.Location.X, brick10.Location.Y, brick10));
                this.bricksList.Add(new Brick(brick11.Location.X, brick11.Location.Y, brick11));
                this.bricksList.Add(new Brick(brick12.Location.X, brick12.Location.Y, brick12));
                this.bricksList.Add(new Brick(brick13.Location.X, brick13.Location.Y, brick13));
                this.bricksList.Add(new Brick(brick14.Location.X, brick14.Location.Y, brick14));
                this.bricksList.Add(new Brick(brick15.Location.X, brick15.Location.Y, brick15));
                this.bricksList.Add(new Brick(brick16.Location.X, brick16.Location.Y, brick16));
                this.bricksList.Add(new Brick(brick17.Location.X, brick17.Location.Y, brick17));
                this.bricksList.Add(new Brick(brick18.Location.X, brick18.Location.Y, brick18));
                this.bricksList.Add(new Brick(brick19.Location.X, brick19.Location.Y, brick19));

            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidPictureException)
            {
                MessageBox.Show(@"No found picture for item!");
            }
            








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

        }

        private void AddItemToList()
        {
            this.itemsPictureBox.Add(item1);
            this.itemsPictureBox.Add(item2);
            this.itemsPictureBox.Add(item3);
            this.itemsPictureBox.Add(item4);
            this.itemsPictureBox.Add(item5);
            this.itemsPictureBox.Add(item6);
            this.itemsPictureBox.Add(item7);
            this.itemsPictureBox.Add(item8);
            this.itemsPictureBox.Add(item9);
            this.itemsPictureBox.Add(item10);
            this.itemsPictureBox.Add(item11);
        }

        //moving hero
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.player.PositionX = hero.Location.X;
            this.player.PositionY = hero.Location.Y;

            if (e.KeyCode == Keys.W)
            {
                hero.Location = player.PositionY >= this.map.Top ?
                    new Point(player.PositionX, player.PositionY - 5) :
                    new Point(player.PositionX, player.PositionY + 5);
            }
            if (e.KeyCode == Keys.S)
            {
                hero.Location = this.player.PositionY <= (this.map.Down - hero.Width) ?
                    new Point(player.PositionX, player.PositionY + 5) :
                    new Point(player.PositionX, player.PositionY - 5);
            }
            if (e.KeyCode == Keys.A)
            {
                hero.Location = this.player.PositionX >= this.map.Left ?
                    new Point(player.PositionX - 5, player.PositionY) :
                    new Point(player.PositionX + 5, player.PositionY);

            }
            if (e.KeyCode == Keys.D)
            {
                hero.Location = this.player.PositionX <= this.map.Right - hero.Height ?
                    new Point(player.PositionX + 5, player.PositionY) :
                    new Point(player.PositionX - 5, player.PositionY);
            }
            if (e.KeyCode == Keys.X)
            {
                InvadersAttack invaderAttack = new InvadersAttack();
                this.Close();
                invaderAttack.Show();
            }

            //check for get item from field
            this.items = this.player.GetItem(items);

            //update values on hero
            this.health_value.Text = Health.HelthCount.ToString();
            this.life_value.Text = Life.LifeCount.ToString();
            this.score_value.Text = Score.ScoreCount.ToString();

            //if lives is zero or negative - game over
            if (Life.LifeCount <= 0)
            {
                MessageBox.Show("Game over");
                Application.Exit();
            }

            //check for exit from this form in door
            if (this.player.CheckForExit(this.door))
            {
                System.Media.SoundPlayer musicPlayer = new System.Media.SoundPlayer("../../Resources/Song/GameMusic.wav");
                musicPlayer.PlayLooping();
                InvadersAttack invaderAttack = new InvadersAttack();
                this.Close();
                invaderAttack.Show();
            }
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

            Obsticle.Left += 1;
            Obsticle2.Left -= 1;
            Obsticle3.Left += 1;
            Obsticle4.Left -= 1;
            Obsticle5.Left += 1;

            if (Obsticle.Left > brick11.Left - Obsticle.Width)
            {
                ObsticleTimer.Enabled = false;
                MoveLeft.Enabled = true;
            }

            DetectCollison(Obsticle, hero, brick5);
            DetectCollison(Obsticle2, hero, brick4);
            DetectCollison(Obsticle3, hero, brick3);
            DetectCollison(Obsticle4, hero, brick2);
            DetectCollison(Obsticle5, hero, brick1);


            //Obsticle.Location=new Point(obsticle.PositionX +1 , obsticle.PositionY);
            //Obsticle2.Location = new Point(obsticle2.PositionX - 1, obsticle2.PositionY);
            //Obsticle3.Location = new Point(obsticle3.PositionX +1, obsticle3.PositionY);
            //Obsticle4.Location = new Point(obsticle4.PositionX + 1, obsticle4.PositionY);
            //Obsticle5.Location = new Point(obsticle5.PositionX + 1, obsticle5.PositionY);

            //if (obsticle.PositionY>=brick5.Location.Y-1)
            //{
            //    if (Obsticle.Right >= brick11.Left)
            //    {
            //        Obsticle.Location=new Point(brick5.Location.X-1,brick5.Location.Y);
            //    }
            //}

            //bool obsticleOne = (
            //                        Obsticle.Location.X + Obsticle.Width >= this.player.Hero.Location.X &&
            //                        Obsticle.Location.X <= this.player.Hero.Left
            //                   ) &&
            //                   (
            //                        Obsticle.Location.Y >= this.player.Hero.Top &&
            //                        Obsticle.Location.Y <= this.player.Hero.Top + this.player.Hero.Height
            //                   );

            //if (obsticleOne)
            //{
            //    Obsticle.Location = new Point(brick5.Location.X - 1, brick5.Location.Y);
            //    Life.LifeCount--;
            //    life_value.Text = Life.LifeCount.ToString();
            //    if (Life.LifeCount == 0)
            //    {
            //        MessageBox.Show("Game over");
            //        Application.Exit();
            //    }
            //}

            //////obsticle2 movement
            ////if (obsticle2.PositionY >= brick4.Location.Y - 1)
            ////{
            ////    if (Obsticle2.Left <= brick4.Right)
            ////    {
            ////        Obsticle2.Location = new Point(brick12.Location.X + 1, brick12.Location.Y);
            ////    }
            ////}
            ////// Obsticle3 movement
            ////if (obsticle3.PositionY >= brick13.Location.Y - 1)
            ////{
            ////    if (Obsticle3.Right >= brick13.Left)
            ////    {
            ////        Obsticle3.Location = new Point(brick3.Location.X - 1, brick3.Location.Y);
            ////    }
            ////}
            ////// Obsticle4 movement
            ////if (obsticle4.PositionY >= brick14.Location.Y - 1)
            ////{
            ////    if (Obsticle4.Right >= brick14.Left)
            ////    {
            ////        Obsticle4.Location = new Point(brick2.Location.X - 1, brick2.Location.Y);
            ////    }
            ////}
            ////// Obsticle5 movement
            ////if (obsticle5.PositionY >= brick15.Location.Y - 1)
            ////{
            ////    if (Obsticle5.Right >= brick15.Left)
            ////    {
            ////        Obsticle5.Location = new Point(brick1.Location.X - 1, brick1.Location.Y);
            ////    }
            ////}
        }
        private void DetectCollison(PictureBox obsticleBox, PictureBox hero, PictureBox brickBox)
        {

            if ((obsticleBox.Location.X + obsticleBox.Width >= hero.Location.X &&
                                    obsticleBox.Location.X <= hero.Left) && (
                                    obsticleBox.Location.Y >= hero.Top &&
                                    obsticleBox.Location.Y <= hero.Top + hero.Height
                               ))
            {
                obsticleBox.Location = new Point(brickBox.Location.X - 1, brickBox.Location.Y);
                Life.LifeCount--;
                life_value.Text = Life.LifeCount.ToString();
                if (Life.LifeCount == 0)
                {
                    MessageBox.Show("Game over");
                    Application.Exit();
                }
            }
        }

        private void MoveLeft_Tick(object sender, EventArgs e)
        {
            Obsticle.Left -= 1;
            Obsticle2.Left += 1;
            Obsticle3.Left -= 1;
            Obsticle4.Left += 1;
            Obsticle5.Left -= 1;
            if (Obsticle.Left < brick5.Right)
            {
                ObsticleTimer.Enabled = true;
                MoveLeft.Enabled = false;
            }

        }
    }
}
