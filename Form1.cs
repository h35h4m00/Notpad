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

namespace Notpad
{
    public partial class Form1 : Form
    {
        string copy_cut="";
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
            
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy_cut = richTextBox1.Text;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy_cut = richTextBox1.Text;
            richTextBox1.Clear();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = copy_cut + richTextBox1.Text;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm=new Form1();
            frm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("text files |*.txt");
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Lines = File.ReadAllLines(openFileDialog1.FileName);
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("text files |*.txt");
            saveFileDialog1.InitialDirectory = "Desktop";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!!!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
