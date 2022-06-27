using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masyunyaForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                return;
            if ((textBox1.Text[textBox1.Text.Length - 1] == ','))
                return;
            try
            {
                double s = Convert.ToDouble(textBox1.Text);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
                return;
            if ((textBox2.Text[textBox2.Text.Length - 1] == ','))
                return;
            try
            {
                double s = Convert.ToDouble(textBox2.Text);
            }
            catch (System.FormatException)
            {
                textBox2.Clear();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("plus");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("minus");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("multiplex");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                if (arg2==0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return;
                }
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("devision");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("power");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("arif");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                double arg2 = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculator calculator =
                    TwoArgumentsFactory.CreateCalculator("geom");
                double res = calculator.Calculate(arg1, arg2);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            try
            {
                double arg1 = Convert.ToDouble(textBox1.Text);
                IOneArgumentCalculator calculator =
                    OneArgumentFactory.CreateCalculator("ex");
                double res = calculator.Calculate(arg1);
                label2.Text = Convert.ToString(res);
            }
            catch (System.FormatException)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        public static bool textBox1Clicked = false;
        public static bool textBox2Clicked = false;
        private void TextBox1_Click(object sender, EventArgs e)
        {
            if (textBox1Clicked==false)
            {
                textBox1.Clear();
                textBox1Clicked = true;
            }
        }

        private void TextBox2_Click(object sender, EventArgs e)
        {
            if (textBox2Clicked == false)
            {
                textBox2.Clear();
                textBox2Clicked = true;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = label2.Text;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\"+\" - сложение." + Environment.NewLine +
                "\"-\" - вычитание." + Environment.NewLine +
                "\"*\" - умножение." + Environment.NewLine +
                "\"/\" - деление." + Environment.NewLine +
                "\"e^x\" - возведение числа e в степень x." + Environment.NewLine +
                "\"^\" - возведение числа x в степень y." + Environment.NewLine +
                "\"Average\" - среднее арифметическое чисел." + Environment.NewLine +
                "\"Geom. Av.\" - среднее геометрическое чисел." + Environment.NewLine +
                "\"Copy to 1,2\" - копировать ответ в строчку с соответствующим номером", "СПРАВКА");
        }
    }
}
