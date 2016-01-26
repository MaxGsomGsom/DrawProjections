using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawProections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1draw_Click(object sender, EventArgs e)
        {


            
            Projections.RectangularIsometry(pictureBox1rectangularIsometry.CreateGraphics(), new double[,] { { 1, 1, 1 }, { -1, -1, -1 } }, new int[,] { { 1, 2 } });
        }
    }
}
