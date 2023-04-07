using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicioCalculadora
{
    public partial class Form1 : Form
    {
        int operacao = 0;
        double num1 = 0, result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void value0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void value1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void value2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void value3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void value4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void value5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void value6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void value7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void value8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void value9_Click(object sender, EventArgs e)
        { 
            textBox1.Text = textBox1.Text + "9";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text.Contains(",")))
                textBox1.Text = textBox1.Text + ",";
        }

        private void add_Click(object sender, EventArgs e)
        {
            operacao = 1;
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();    
        }

        private void sub_Click(object sender, EventArgs e)
        {
            operacao = 2;
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            operacao = 3;
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            operacao = 4;
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                textBox1.Text = "ERRO";
            else if (operacao == 1)
                result = num1 + double.Parse(textBox1.Text);
            else if (operacao == 2)
                result = num1 - double.Parse(textBox1.Text);
            else if (operacao == 3)
                result = num1 * double.Parse(textBox1.Text);
            else if (operacao == 4)
                result = num1 / double.Parse(textBox1.Text);

            textBox1.Text = result.ToString();
            operacao = -1;
        }
    }
}
