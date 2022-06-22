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

        private void Button1_Click(object sender, EventArgs e)
        {
            double arg1 = Convert.ToDouble(textBox1.Text);
            double arg2 = Convert.ToDouble(textBox2.Text);
            double res = arg1 + arg2;
            label1.Text = Convert.ToString(res);
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
                MessageBox.Show("Вводить можно только цифры и запятую!");
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
                MessageBox.Show("Вводить можно только цифры и запятую!");
                textBox2.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double arg1 = Convert.ToDouble(textBox1.Text);
            double arg2 = Convert.ToDouble(textBox2.Text);
            double res = arg1 - arg2;
            label1.Text = Convert.ToString(res);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double arg1 = Convert.ToDouble(textBox1.Text);
            double arg2 = Convert.ToDouble(textBox2.Text);
            double res = arg1 * arg2;
            label1.Text = Convert.ToString(res);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double arg1 = Convert.ToDouble(textBox1.Text);
            double arg2 = Convert.ToDouble(textBox2.Text);
            double res = arg1 / arg2;
            label1.Text = Convert.ToString(res);
        }
    }
}
