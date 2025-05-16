using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyWinApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text.Length == 0)

            {

                errorProvider1.SetError(textBox1, "Please enter name");

            }

            else

            {

                errorProvider1.Clear();

            }


            if (textBox1.Text != textBox2.Text)

            {

                errorProvider1.SetError(textBox2, "password mismatch");

            }

            string result = textBox1.Text + "\n";

            result += textBox2.Text + "\n";

            if (radioButton1.Checked)

            {

                result += "Male\n";

            }

            else

            {

                result += "Female\n";

            }


            result += dateTimePicker1.Text + "\n";
            result += comboBox1.Text + "\n";

            result += listBox1.Text;

            if (checkBox1.Checked==true)

            {
                result += checkBox1.Text + "\n";
            }
            if (checkBox2.Checked == true)

            {
                result += checkBox2.Text + "\n";
            }
            if (checkBox3.Checked == true)

            {
                result += checkBox3.Text+"\n";
            }
            if (checkBox4.Checked == true)

            {
                result += checkBox4.Text + "\n";
            }

            label9.Text = result;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
