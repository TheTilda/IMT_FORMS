using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMT28._11._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox1.Text);
            h = h / 100;
            double result = m / (h * h);

            if (result < 18.5)
            {
                label3.Text = string.Format("Ваш индекс массы тела: {0}", Convert.ToString(result));
                label3.BackColor = Color.Yellow;
                label3.ForeColor = Color.Black;
                pictureBox1.Image = Properties.Resources.hud;

            }
            else if (result <= 25 && result > 18.5)
            {
                label3.Text = string.Format("Ваш индекс массы тела: {0}", Convert.ToString(result));
                label3.BackColor = Color.Green;
                pictureBox1.Image = Properties.Resources.giga1;
            }
            else {
                label3.Text = string.Format("Ваш индекс массы тела: {0}", Convert.ToString(result));
                label3.BackColor = Color.Red;
                pictureBox1.Image = Properties.Resources.nonjirn;
            }
           

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
