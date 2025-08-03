using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);

            int xx = number1 + number2;
            string yy = Convert.ToString(xx);
            result.Text = yy;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);

            int xx = number1 - number2;
            string yy = Convert.ToString(xx);
            result.Text = yy;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);

            int xx = number1 * number2;
            string yy = Convert.ToString(xx);
            result.Text = yy;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);

            int xx = number1 / number2;
            string yy = Convert.ToString(xx);
            result.Text = yy;
        }
    }
}
