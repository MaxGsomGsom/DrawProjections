using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            //парсинг данных
            double[,] dots = ParseDots();
            int[,] lines = ParseLines();

            //очистка поля
            Graphics g = pictureBox1draw.CreateGraphics();
            g.Clear(Color.White);

            //в зависимости от выбранного варианта отрисовываем нужную проекцию
            if (radioButton1.Checked)
            {
                Projections.DrawLines(g, dots, lines, Projections.RectangularIsometry);
            }
            else if (radioButton2.Checked)
            {
                Projections.DrawLines(g, dots, lines, Projections.RectangularDimetry);
            }
            else if (radioButton3.Checked)
            {
                Projections.DrawLines(g, dots, lines, Projections.HorisontalIsometry);
            }
            else if (radioButton4.Checked)
            {
                Projections.DrawLines(g, dots, lines, Projections.FrontalIsometry);
            }
            else if (radioButton5.Checked)
            {
                Projections.DrawLines(g, dots, lines, Projections.FrontalDimetry);
            }
            else if (radioButton6.Checked)
            {
                Projections.DrawLines(g, dots, lines, Projections.Perspective);
            }

        }


        #region Parse

        /// <summary>
        /// Парсинг и создание массива точек тела
        /// </summary>
        /// <returns></returns>
        double[,] ParseDots()
        {
            MatchCollection matches = Regex.Matches(textBox1dots.Text, "-?\\d\\d*");

            double[,] dots = new double[matches.Count / 3, 3];

            for (int i = 0; i < matches.Count / 3; i++)
            {
                dots[i, 0] = Convert.ToDouble(matches[i * 3].Value);
                dots[i, 1] = Convert.ToDouble(matches[i * 3 + 1].Value);
                dots[i, 2] = Convert.ToDouble(matches[i * 3 + 2].Value);
            }

            return dots;

        }


        /// <summary>
        /// Парсинг и создание массива отрезков, которые соединяют точки тела
        /// </summary>
        /// <returns></returns>
        int[,] ParseLines()
        {
            MatchCollection matches = Regex.Matches(textBox1lines.Text, "\\d\\d*");

            int[,] lines = new int[matches.Count / 2, 2];

            for (int i = 0; i < matches.Count / 2; i++)
            {
                lines[i, 0] = Convert.ToInt32(matches[i * 2].Value)-1;
                lines[i, 1] = Convert.ToInt32(matches[i * 2 + 1].Value)-1;
            }

            return lines;

        }

        #endregion


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Projections.PerspectiveAngle = trackBar1.Value;
        }
    }
}
