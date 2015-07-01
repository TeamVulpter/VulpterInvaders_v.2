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

    using Engine;

    using Exception;

    using Interfaces;

    public partial class VulpterInvadersGame : Form
    {
        private readonly IMap map;
        private readonly Player player;
        private IList<Brick> bricksList = new List<Brick>();
        private IList<ObsticleBrick> obsticles;
        private IList<Item> items;
        private List<PictureBox> itemsPictureBox = new List<PictureBox>();

        public VulpterInvadersGame()
        {
            InitializeComponent();
            try
            {
                //generation map coordinates

                this.map = new Map( this.brick16.Location.Y + this.brick16.Height,
                                    this.brick6.Location.Y,
                                    this.brick1.Location.X + this.brick1.Width,
                                    this.brick11.Location.X);

                this.items = new List<Item>();
                this.obsticles = new List<ObsticleBrick>();

                this.map = new Map(this.brick16.Location.Y + this.brick16.Height,
                    this.brick6.Location.Y,
                    this.brick1.Location.X + this.brick1.Width,
                    this.brick11.Location.X);
                this.items = new List<Item>();
                this.obsticles = new List<ObsticleBrick>();

                //create player
                this.player = new Player(hero);

                //add item to list of items
                this.AddItemToList();

                //add all obsticle to list
                AddObsticleToList();
                //drawing bricks
                this.AddBrickToList();


                //generation items with bonus
                ItemsFactory itemsFactory = new ItemsFactory();
                items = itemsFactory.CreateItems(11, itemsPictureBox, this.map);

                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidPictureException)
            {
                MessageBox.Show(@"No found picture for item!");
            }
            
        }

        //add item to list of items
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

        private void AddObsticleToList()
        {
            this.obsticles.Add(new ObsticleBrick(Obsticle));
            this.obsticles.Add(new ObsticleBrick(Obsticle2));
            this.obsticles.Add(new ObsticleBrick(Obsticle3));
            this.obsticles.Add(new ObsticleBrick(Obsticle4));
            this.obsticles.Add(new ObsticleBrick(Obsticle5));
        }

        //add all rick to list
        private void AddBrickToList()
        {
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

        //moving hero
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!player.StopAtMin(player.Hero.Location.Y, this.map.Top))
            {
                if (e.KeyCode == Keys.W)
                {
                    player.MoveUp();
                }
            }
            if (!player.StopAtMax(player.Hero.Location.Y+player.Hero.Height, this.map.Down))
            {
                if (e.KeyCode == Keys.S)
                {
                    player.MoveDown();
                }
            }
            if (!player.StopAtMin(player.Hero.Location.X, this.map.Left))
            {
                if (e.KeyCode == Keys.A)
                {
                    player.MoveLeft();
                }
            }
            if (!player.StopAtMax(player.Hero.Location.X+player.Hero.Width, this.map.Right))
            {
                if (e.KeyCode == Keys.D)
                {
                    player.MoveRight();
                }
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

            AdvancedStatistics.GameHealthMax();
            AdvancedStatistics.GameScoreMax();
            AdvancedStatistics.GameExit();

            //check for exit from this form in door
            if (this.player.CheckForExit(this.door))
            {
                //System.Media.SoundPlayer musicPlayer = new System.Media.SoundPlayer("../../Resources/Song/GameMusic.wav");
                //musicPlayer.PlayLooping();
                InvadersAttack invaderAttack = new InvadersAttack();
                this.Close();
                invaderAttack.Show();
            }
        }

        private void ObsticleTimer_Tick(object sender, EventArgs e)
        {
            Obsticle.Left += 1;
            if (DetectCollison(Obsticle, hero))
            {
                Obsticle.Left -= 1;
                ObsticleTimer.Enabled = false;
                MoveLeft.Enabled = true;

            }
            else if (Obsticle.Right > this.map.Right)
            {
                ObsticleTimer.Enabled = false;
                MoveLeft.Enabled = true;
            }
        }
        private void MoveLeft_Tick(object sender, EventArgs e)
        {
            Obsticle.Left -= 1;
            if (DetectCollison(Obsticle, hero))
            {
                Obsticle.Left += 1;
                ObsticleTimer.Enabled = true;
                MoveLeft.Enabled = false;
            }
            else if (Obsticle.Left < this.map.Left)
            {
                ObsticleTimer.Enabled = true;
                MoveLeft.Enabled = false;
            }

        }

        private void Obsticle2MoveLeft_Tick(object sender, EventArgs e)
        {
            Obsticle2.Left -= 1;
            if (DetectCollison(Obsticle2, hero))
            {
                //Obsticle2.Left += 1;
                Obsticle2MoveLeft.Enabled = false;
                Obsticle2MoveRIght.Enabled = true;
            }
            else if (Obsticle2.Left < map.Left)
            {
                Obsticle2MoveLeft.Enabled = false;
                Obsticle2MoveRIght.Enabled = true;
            }
        }
        private void Obsticle2MoveRight_Tick(object sender, EventArgs e)
        {
            Obsticle2.Left += 1;
            if (DetectCollison(Obsticle2, hero))
            {
                //Obsticle2.Left -= 1;
                Obsticle2MoveLeft.Enabled = true;
                Obsticle2MoveRIght.Enabled = false;

            }
            else if (Obsticle2.Right > this.map.Right)
            {
                Obsticle2MoveLeft.Enabled = true;
                Obsticle2MoveRIght.Enabled = false;
            }
        }

        private void Obsticle3MoveRight_Tick(object sender, EventArgs e)
        {
            Obsticle3.Left += 1;
            if (DetectCollison(Obsticle3, hero))
            {
                Obsticle3.Left -= 1;
                Obsticle3MoveRight.Enabled = false;
                Obsticle3MoveLeft.Enabled = true;

            }
            if (Obsticle3.Right > this.map.Right)
            {
                Obsticle3MoveRight.Enabled = false;
                Obsticle3MoveLeft.Enabled = true;
            }
        }
        private void Obsticle3MoveLeft_Tick(object sender, EventArgs e)
        {
            Obsticle3.Left -= 1;
            if (DetectCollison(Obsticle3, hero))
            {
                Obsticle3.Left += 1;
                Obsticle3MoveLeft.Enabled = false;
                Obsticle3MoveRight.Enabled = true;
            }
            else if (Obsticle3.Left < this.map.Left)
            {
                Obsticle3MoveRight.Enabled = true;
                Obsticle3MoveLeft.Enabled = false;
            }
        }

        private void Obsticle4MoveLeft_Tick(object sender, EventArgs e)
        {

            Obsticle4.Left -= 1;
            if (DetectCollison(Obsticle4, hero))
            {
                Obsticle4.Left += 1;
                Obsticle4MoveLeft.Enabled = false;
                Obsticle4MoveRight.Enabled = true;
            }
            else if (Obsticle4.Left < this.map.Left)
            {
                Obsticle4MoveLeft.Enabled = false;
                Obsticle4MoveRight.Enabled = true;
            }
        }
        private void Obsticle4MoveRigth_Tick(object sender, EventArgs e)
        {
            Obsticle4.Left += 1;
            if (DetectCollison(Obsticle4, hero))
            {
                Obsticle4.Left -= 1;
                Obsticle4MoveLeft.Enabled = true;
                Obsticle4MoveRight.Enabled = false;
            }
            else if (Obsticle4.Right > this.map.Right)
            {
                Obsticle4MoveLeft.Enabled = true;
                Obsticle4MoveRight.Enabled = false;
            }
        }

        private void Obsticle5MoveRight_Tick(object sender, EventArgs e)
        {
            Obsticle5.Left += 1;
            if (DetectCollison(Obsticle5, hero))
            {
                Obsticle5.Left -= 1;
                Obsticle5MoveRight.Enabled = false;
                Obsticle5MoveLeft.Enabled = true;

            }
            else if (Obsticle5.Right > this.map.Right)
            {
                Obsticle5MoveRight.Enabled = false;
                Obsticle5MoveLeft.Enabled = true;
            }
        }
        private void Obsticle5MoveLeft_Tick(object sender, EventArgs e)
        {
            Obsticle5.Left -= 1;
            if (DetectCollison(Obsticle5, hero))
            {
                Obsticle5.Left += 1;
                Obsticle5MoveLeft.Enabled = false;
                Obsticle5MoveRight.Enabled = true;
            }
            if (Obsticle5.Left < this.map.Left)
            {
                Obsticle5MoveRight.Enabled = true;
                Obsticle5MoveLeft.Enabled = false;
            }
        }


        private bool DetectCollison(PictureBox obsticleBox, PictureBox hero)
        {
            if ((obsticleBox.Location.X + obsticleBox.Width == hero.Location.X && obsticleBox.Location.Y >= hero.Top &&
                                   obsticleBox.Location.Y <= hero.Top + hero.Height ))
            {
                return true;
            }
            return false;
        }
    }
}

