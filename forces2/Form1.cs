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
                double a = double.Parse(textBox1.Text);
                double ans = tan(a);
                label1.Text = ans.ToString();
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

        private double cos(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Cos(rad);
        }

        private double tan(double a)
        {
            double rad = a / 180.0 * Math.PI;
            return Math.Tan(rad);
        }
    }
}

