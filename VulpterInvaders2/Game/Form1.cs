using System;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        private int[,] matrix;

        public Form1()
        {
            InitializeComponent();
            this.matrix = new int[10,10];
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

        private void start_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Create");
        }
    }
}
