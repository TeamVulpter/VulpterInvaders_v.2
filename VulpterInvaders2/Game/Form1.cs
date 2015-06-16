namespace Game
{
    using System;
    using System.Windows.Forms;
    using Interfaces;
    using Classes;

    public partial class Form1 : Form
    {
        private DrawFields matrix;
        private IHero hero;

        public Form1()
        {
            InitializeComponent();
            try
            {
                this.matrix = new DrawFields(new int[40, 40]);
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

        //button for start
        private void start_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        //button for create hero
        private void button1_Click(object sender, EventArgs e)
        {
            //IHero hero = new 
            MessageBox.Show("Create");
        }
    }
}
