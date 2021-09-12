using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double h = Convert.ToDouble(textBox2.Text);
            double m = Convert.ToDouble(textBox4.Text);
            double c = Math.Sqrt(2*m/(a*b*h));
            textBox5.Text = c.ToString();
        }
    }
}
