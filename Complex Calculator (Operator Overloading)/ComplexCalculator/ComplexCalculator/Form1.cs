using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1box.Text);
            double r2 = Convert.ToDouble(r2box.Text);
            double i1 = Convert.ToDouble(i1box.Text);
            double i2 = Convert.ToDouble(i2box.Text);

            Complex a = new Complex(r1, i1);
            Complex b = new Complex(r2, i2);

            Complex c = a + b;

            resultLabel.Text = "Result: " + c.getReal() + "+" + c.getImaginary() + "i";
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1box.Text);
            double r2 = Convert.ToDouble(r2box.Text);
            double i1 = Convert.ToDouble(i1box.Text);
            double i2 = Convert.ToDouble(i2box.Text);

            Complex a = new Complex();
            Complex b = new Complex();

            a.setReal(r1);
            a.setImaginary(i1);
            b.setReal(r2);
            b.setImaginary(i2);

            Complex c = a - b;

            resultLabel.Text = "Result: " + c.getReal() + "+" + c.getImaginary() + "i";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1box.Text);
            double r2 = Convert.ToDouble(r2box.Text);
            double i1 = Convert.ToDouble(i1box.Text);
            double i2 = Convert.ToDouble(i2box.Text);

            Complex a = new Complex(r1, i1);
            Complex b = new Complex(r2, i2);

            Complex c = a * b;

            resultLabel.Text = "Result: " + c.getReal() + "+" + c.getImaginary() + "i";

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            double r1 = Convert.ToDouble(r1box.Text);
            double r2 = Convert.ToDouble(r2box.Text);
            double i1 = Convert.ToDouble(i1box.Text);
            double i2 = Convert.ToDouble(i2box.Text);

            Complex a = new Complex(r1, i1);
            Complex b = new Complex(r2, i2);

            Complex c = a / b;

            resultLabel.Text = "Result: " + c.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            r1box.Text = String.Empty;
            r2box.Text = String.Empty;
            i1box.Text = String.Empty;
            i2box.Text = String.Empty;

            resultLabel.Text = "Result: " + "0";
        }
    }
}
