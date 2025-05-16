using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyWinApp
{
    public partial class RegExDemo : Form
    {
        bool res;
        public RegExDemo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             res = Regex.IsMatch(textBox1.Text, "^[a-zA-Z]+$");
             label1.Text = res.ToString();
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegExDemo_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           var r = Regex.IsMatch(textBox1.Text, "^[a-zA-Z0-9]+[@][a-z]+[.][a-z]+$");
            label1.Text = r.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             res = Regex.IsMatch(textBox1.Text, "^[0-9]+$");
            label1.Text =res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            res = Regex.IsMatch(textBox1.Text, "^\\S+$");
            label1.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            res = Regex.IsMatch(textBox1.Text, "^[0-9a-zA-z]+$");
            label1.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string replaced = Regex.Replace(input, @"\d+", Regex.Match(input, "[a-z]+").ToString());
            label1.Text = replaced;

           // label1.Text = res.ToString();
         
            
        }
    }
}
