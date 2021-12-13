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





namespace Compass
{
    

    public partial class Form1 : Form
    {
        public int[] themeDark = { 46, 46, 48, 190, 190, 190 };
        public int[] themeLight = { 190, 190, 190, 46, 46, 48 };
        public bool themeState; // true = themeDark
        public Form1()
        {
            InitializeComponent();
            formColors(46, 46, 48, 190, 190, 190);
            themeState = true;
                      
        }

        private void formColors(int rBack, int gBack, int bBack, int rFront, int gFront, int bFront)
        {
            //main Window
            this.BackColor = Color.FromArgb(rBack, gBack, bBack);
            label1.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            label2.ForeColor = Color.FromArgb(rFront, gFront, bFront);

            //Tool strip
            menuStrip1.BackColor = Color.FromArgb(rBack, gBack, bBack);

            //file tool strip menu
            fileToolStripMenuItem.BackColor   = Color.FromArgb(rBack, gBack, bBack);
            fileToolStripMenuItem.ForeColor   = Color.FromArgb(rFront, gFront, bFront);
            newToolStripMenuItem.BackColor    = Color.FromArgb(rBack, gBack, bBack);
            newToolStripMenuItem.ForeColor    = Color.FromArgb(rFront, gFront, bFront);
            openToolStripMenuItem.BackColor   = Color.FromArgb(rBack, gBack, bBack);
            openToolStripMenuItem.ForeColor   = Color.FromArgb(rFront, gFront, bFront);
            saveToolStripMenuItem.BackColor   = Color.FromArgb(rBack, gBack, bBack);
            saveToolStripMenuItem.ForeColor   = Color.FromArgb(rFront, gFront, bFront);
            saveAsToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            saveAsToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            exitToolStripMenuItem.BackColor   = Color.FromArgb(rBack, gBack, bBack);
            exitToolStripMenuItem.ForeColor   = Color.FromArgb(rFront, gFront, bFront);

            //edit tool strip menu
            editToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            editToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            undoToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            undoToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            redoToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            redoToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            cutToolStripMenuItem.BackColor  = Color.FromArgb(rBack, gBack, bBack);
            cutToolStripMenuItem.ForeColor  = Color.FromArgb(rFront, gFront, bFront);
            copyToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            copyToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            pasteToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            pasteToolStripMenuItem.ForeColor     = Color.FromArgb(rFront, gFront, bFront);
            selectAllToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            selectAllToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);

            //tools tool strip
            toolsToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            toolsToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            themeToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            themeToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            darkToolStripMenuItem.BackColor  = Color.FromArgb(rBack, gBack, bBack);
            darkToolStripMenuItem.ForeColor  = Color.FromArgb(rFront, gFront, bFront);
            lightToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            lightToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);

            //help tool strip
            helpToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            helpToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
            aboutToolStripMenuItem.BackColor = Color.FromArgb(rBack, gBack, bBack);
            aboutToolStripMenuItem.ForeColor = Color.FromArgb(rFront, gFront, bFront);
                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Drop Down Menus
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Open a file...";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                using (StreamReader sr = new StreamReader(openfile.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Save file as...";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(savefile.FileName);
                txtoutput.Write(richTextBox1.Text);
                txtoutput.Close();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            if(themeState == true)
            {
                // Dark Theme
                aboutWindow.BackColor = Color.FromArgb(46, 46, 48);
                aboutWindow.ForeColor = Color.FromArgb(190, 190, 190);
            }
            else
            {
                // Light Theme
                aboutWindow.BackColor = Color.FromArgb(190, 190, 190);
                aboutWindow.ForeColor = Color.FromArgb(46, 46, 48);
            }

            aboutWindow.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] files = Directory.GetFiles(FBD.SelectedPath);
                string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

                foreach (string file in files)
                {
                    listBox1.Items.Add(file);
                }

                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(dir);
                }
            }
        }
         private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void themeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themeState = true;
            darkToolStripMenuItem.CheckState = CheckState.Checked;
            lightToolStripMenuItem.CheckState = CheckState.Unchecked;
            formColors(46, 46, 48, 190, 190, 190);
                        
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themeState = false;
            darkToolStripMenuItem.CheckState = CheckState.Unchecked;
            lightToolStripMenuItem.CheckState = CheckState.Checked;
            formColors(190, 190, 190, 46, 46, 48);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     }
}
