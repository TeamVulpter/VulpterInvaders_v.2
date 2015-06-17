using System.Drawing;
using Game.Classes.Matrix;

namespace Game
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using Classes;
    using Game.Classes.Characters;

    public partial class VulpterInvadersGame : Form
    {
        private Map matrix;
        private Brick bricks;
        private Player player;

        public VulpterInvadersGame()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            
            try
            {
                this.matrix = new Map(new int[40, 40]);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player(hero.Location.X, hero.Location.Y, hero);
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
            
        }

        //button for start
        private void start_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        //button for create hero
        private void button1_Click(object sender, EventArgs e)
        {
            //this.player = new Player(0, 0, "Arthur");
            MessageBox.Show("Create");
        }

        private void hero_Click(object sender, EventArgs e)
        {

        }
    }
}
