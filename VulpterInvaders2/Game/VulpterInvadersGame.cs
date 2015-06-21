using System.Collections.Generic;
using System.Drawing;
using Game.Classes.Matrix;

namespace Game
{
    using System;
    using System.Windows.Forms;
    using Game.Classes.Characters;
    using Classes.Items;

    public partial class VulpterInvadersGame : Form
    {
        
        //private Brick bricks;
        private Player player;
        private Item item;
        private Brick bricks;
        private IList<Brick> bricksList= new List<Brick>();
        private Map matrix=new Map();
        private int[,] playField;

        public VulpterInvadersGame()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.player = new Player(500, 0, hero);
            this.bricksList.Add(new Brick(brick.Location.X, brick.Location.Y, brick));
            this.bricksList.Add(new Brick(brick1.Location.X, brick1.Location.Y, brick1));
            this.item = new Item(10, 10);
            try
            {
                this.playField = this.matrix.DrawField();
                this.player.AddHealth(300);
                this.player.RemoveHealth(100);
                this.player.AddLives(2);
                this.player.RemoveLives(1);
                this.player.AddScores(300);
                this.player.RemoveScores(125);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < playField.GetLength(0); i++)
            {
                for (int j = 0; j < playField.GetLength(1); j++)
                {
                    if (playField[i, j] == 1)
                    {
                        foreach (var br in bricksList)
                        {
                            if (br.BrickSingle.Location.X == j )
                            {
                                br.BrickSingle.Visible = true;
                            }
                            
                        }

                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.player.PositionX = hero.Location.X;
            this.player.PositionY = hero.Location.Y;
           
            if (e.KeyCode == Keys.W)
            {
                hero.Location = new Point(player.PositionX, player.PositionY-10);
            }
            if (e.KeyCode == Keys.S)
            {
                hero.Location = new Point(player.PositionX, player.PositionY +10);
            }
            if (e.KeyCode == Keys.A)
            {
                hero.Location = new Point(player.PositionX-10, player.PositionY);
            }
            if (e.KeyCode == Keys.D)
            {
                hero.Location = new Point(player.PositionX + 10, player.PositionY);
            }
            if (e.KeyCode==Keys.X)
            {
                InvadersAttack invaderAttack = new InvadersAttack();
                invaderAttack.Show();
                Hide();
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
    }
}
