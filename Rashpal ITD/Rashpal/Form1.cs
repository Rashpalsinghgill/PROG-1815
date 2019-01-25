using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashpal
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_tab = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(operation_tab))
            textBox1.Clear();
            operation_tab = false;
            Button c = (Button)sender;
            textBox1.Text = textBox1.Text + c.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button c = (Button)sender;
            operation = c.Text;
            value = double.Parse(textBox1.Text);
            operation_tab = true;
            label1.Text= value + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }
    }
}
