using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text); // преобр. строку в число 
            double z = a * a;
            textBox2.Text = Convert.ToString(z); // преобр. число в строку

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text); // преобр. строку в число
            double b = Convert.ToDouble(textBox2.Text);
            double c = a + b;
            textBox4.Text = Convert.ToString(c); // преобр. число в строку
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text); // преобр. строку в число
            double b = Convert.ToDouble(textBox2.Text);
            double c = a - b;
            textBox4.Text = Convert.ToString(c); // преобр. число в строку
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text); // преобр. строку в число
            double b = Convert.ToDouble(textBox2.Text);
            double c = a * b;
            textBox4.Text = Convert.ToString(c); // преобр. число в строку
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text); // преобр. строку в число
            double b = Convert.ToDouble(textBox2.Text);
            double c = a / b;
            textBox4.Text = Convert.ToString(c); // преобр. число в строку
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
