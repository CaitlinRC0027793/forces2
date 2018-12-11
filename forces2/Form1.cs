using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double f = double.Parse(textBox1.Text);
                double a = double.Parse(textBox2.Text);
                double fx = f * cos(a);
                double fy = f * sin(a);
                label1.Text = "Fx = " + fx + "N";
                label2.Text = "Fy = " + fy + "N";
            }
            catch
            {
                MessageBox.Show("Enter a number");
            }
        }
        private double sin(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Sin(rad);
        }
        private double Asin(double a)
        {
            return Math.Asin(a) * 180.0 / Math.PI;
        }

        private double cos(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Cos(rad);
        }
        private double Acos(double a)
        {
            return Math.Acos(a) * 180.0 / Math.PI;
        }

        private double tan(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Tan(rad);
        }
        private double Atan(double a)
        {
            return Math.Atan(a) * 180.0 / Math.PI;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

