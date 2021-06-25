using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using org.mariuszgromada.math.mxparser;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string equation = string.Empty;
        double result = 0.0;

        Expression expression;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "0";
            this.textBox1.Text += equation;
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "1";
            this.textBox1.Text += equation;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "2";
            this.textBox1.Text += equation;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "3";
            this.textBox1.Text += equation;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "4";
            this.textBox1.Text += equation;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "5";
            this.textBox1.Text += equation;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "6";
            this.textBox1.Text += equation;
        }
        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "7";
            this.textBox1.Text += equation;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "8";
            this.textBox1.Text += equation;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "9";
            this.textBox1.Text += equation;
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "%";
            this.textBox1.Text += equation;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            equation = string.Empty;
            result = 0.0;
            this.textBox1.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            if (equation.Length >= 1)
            {
                equation = equation.Substring(0, equation.Length - 1);
            }

            this.textBox1.Text += equation;
        }

        private void oneOverX_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation = $"1/({equation})";
            this.textBox1.Text += equation;

        }

        private void square_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation = $"({equation} ^ 2)";
            this.textBox1.Text += equation;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation = $"sqrt({equation})";
            this.textBox1.Text += equation;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "/";
            this.textBox1.Text += equation;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "*";
            this.textBox1.Text += equation;
        }


        private void subtract_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "-";
            this.textBox1.Text += equation;
        }


        private void addition_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "+";
            this.textBox1.Text += equation;
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation += "/";
            this.textBox1.Text += equation;
        }

        private void negPos_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation = $"-({equation})";
            this.textBox1.Text += equation;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            equation = equation.Replace('%', '#');
            expression = new Expression(equation);
            result = expression.calculate();
            this.textBox1.Text += result.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
