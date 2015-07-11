namespace Game
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Classes;
    using Classes.Characters;
    using Classes.Bricks;
    using Classes.Factory;
    using Classes.Items;
    using Classes.Map;

    using Exception;

    using Interfaces;

    public partial class VulpterInvadersGame : Form
    {
        private readonly IMap map;
        private readonly Player player;
        private IList<Brick> bricksList;
        private IList<ObsticleBrick> obsticles;
        private IList<Item> items;
        private List<PictureBox> itemsPictureBox;
        

        public VulpterInvadersGame()
        {
            InitializeComponent();
            try
            {
                itemsPictureBox = new List<PictureBox>();
                bricksList = new List<Brick>()
                {
                    new Brick(brick16),
                    new Brick(brick6),
                    new Brick(brick1),
                    new Brick(brick11)
                };

                //generation map coordinates
                this.map = new Map(this.bricksList[0].BrickSingle.Location.Y + this.bricksList[0].BrickSingle.Height,
                                    this.bricksList[1].BrickSingle.Location.Y,
                                    this.bricksList[2].BrickSingle.Location.X + this.brick1.Width,
                                    this.bricksList[3].BrickSingle.Location.X);

                this.items = new List<Item>();
                this.obsticles = new List<ObsticleBrick>();

                //create player
                this.player = new Player(hero);

                //add item to list of items
                this.AddItemToList();

                //add all obsticle to list
                this.AddObsticleToList();

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
                MessageBox.Show(@"Not found picture for item!");
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
            if (!player.StopAtMax(player.Hero.Location.Y + player.Hero.Height, this.map.Down))
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
            if (!player.StopAtMax(player.Hero.Location.X + player.Hero.Width, this.map.Right))
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
            this.health_value.Text = Health.HealthCount.ToString();
            this.life_value.Text = Life.LifeCount.ToString();
            this.score_value.Text = Score.ScoreCount.ToString();

            AdvancedStatistics.GameHealthMax();
            AdvancedStatistics.GameHealthMin();

            if (Life.LifeCount <= 0 || Score.ScoreCount >= 100)
            {
                GameOverForm gameOver = new GameOverForm();
                gameOver.Show();
                this.Close();
            }

            //check for exit from this form in door
            if (this.player.CheckForExit(this.door))
            {
                InvadersAttack invaderAttack = new InvadersAttack();
                this.Close();
                invaderAttack.Show();
            }
        }

        private void ObsticleMoveRight_Tick(object sender, EventArgs e)
        {
            obsticles[0].MoveRight();
            if (DetectCollison(Obsticle, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[0].MoveLeft();
                ObsticleMoveRight.Enabled = false;
                ObsticleMoveLeft.Enabled = true;

            }
            else if (Obsticle.Right > this.map.Right)
            {
                ObsticleMoveRight.Enabled = false;
                ObsticleMoveLeft.Enabled = true;
            }
        }
        private void ObsticleMoveLeft_Tick(object sender, EventArgs e)
        {
            obsticles[0].MoveLeft();
            if (DetectCollison(Obsticle, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[0].MoveRight();
                ObsticleMoveRight.Enabled = true;
                ObsticleMoveLeft.Enabled = false;
            }
            else if (Obsticle.Left < this.map.Left)
            {
                ObsticleMoveRight.Enabled = true;
                ObsticleMoveLeft.Enabled = false;
            }

        }

        private void Obsticle2MoveLeft_Tick(object sender, EventArgs e)
        {
            obsticles[1].MoveLeft();
            if (DetectCollison(Obsticle2, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[1].MoveRight();
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
            obsticles[1].MoveRight();
            if (DetectCollison(Obsticle2, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[1].MoveLeft();
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
            obsticles[2].MoveRight();
            if (DetectCollison(Obsticle3, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[2].MoveLeft();
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
            obsticles[2].MoveLeft();
            if (DetectCollison(Obsticle3, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[2].MoveRight();
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

            obsticles[3].MoveLeft();
            if (DetectCollison(Obsticle4, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[3].MoveRight();
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
            obsticles[3].MoveRight();
            if (DetectCollison(Obsticle4, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[3].MoveLeft();
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
            obsticles[4].MoveRight();
            if (DetectCollison(Obsticle5, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[4].MoveLeft();
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
            obsticles[4].MoveLeft();
            if (DetectCollison(Obsticle5, hero))
            {
                Health.HealthCount -= 10;
                this.health_value.Text = Health.HealthCount.ToString();
                obsticles[4].MoveRight();
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
            if ((obsticleBox.Location.X + obsticleBox.Width == hero.Location.X &&
                    obsticleBox.Location.Y >= hero.Top &&
                    obsticleBox.Location.Y <= hero.Top + hero.Height))
            {
                return true;
            }

            if (obsticleBox.Location.X == (hero.Location.X + hero.Width) &&
                    obsticleBox.Location.Y >= hero.Top &&
                    obsticleBox.Location.Y <= hero.Top + hero.Height)
            {
                return true;
            }

            return false;
        }

        private void VulpterInvadersGame_Load(object sender, EventArgs e)
        {

        }
    }
}

