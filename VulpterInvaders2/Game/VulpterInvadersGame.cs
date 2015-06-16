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

        private void hero_MouseEnter(object sender, EventArgs e)
        {
            this.player.PositionX = hero.Location.X;
            this.player.PositionY = hero.Location.Y;
            hero.Location = new Point(player.PositionX + 25, player.PositionY);
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
    }
}
