using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyWinApp
{
    public partial class MyNotePad : Form
    {
        public MyNotePad()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Total Character are: ";
            toolStripStatusLabel2.Text += richTextBox1.Text.Length.ToString();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            richTextBox1.ForeColor = cld.Color;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();

            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (o.ShowDialog() == DialogResult.OK)
            {
                string filePath = o.FileName;
                string content = File.ReadAllText(filePath);
                richTextBox1.Text = content;

                
            }


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, richTextBox1.Text);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog p = new PrintDialog();
            p.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorToolStripMenuItem_Click(sender, e);
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor += 2.5f;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MyNotePad_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text =  DateTime.Now.ToString();
           

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
