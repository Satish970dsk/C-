using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           // MessageBox.Show(textBox1.Text + textBox2.Text);
            if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                label1.Text = textBox1.Text;
            }

            else
            {
                label1.Text = textBox2.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button1_Click(sender, e);   
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter a value in the first text box.");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please enter a value in the second text box.");
            }
        }
    }
}
