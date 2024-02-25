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

namespace Notepad_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dlg = new OpenFileDialog(); 
            dlg.Title = "Open";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            StreamReader sr = new StreamReader(fName); 
            txtContent.Text = sr.ReadToEnd();
            sr.Close();
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(fName);
            sw.Write(txtContent.Text);
            sw.Flush();
            sw.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog(); 
            fd.Font = txtContent.SelectionFont;
            fd.Color = txtContent.SelectionColor; 
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtContent.SelectionFont = fd.Font;
                txtContent.SelectionColor = fd.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            fd.Color = txtContent.SelectionColor;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtContent.SelectionColor = fd.Color;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           txtContent.SelectAll();
           if (txtContent.SelectedText != "")
           {
               SaveFileDialog saveFileDialog1 = new SaveFileDialog();
               saveFileDialog1.ShowDialog();
               string fName = saveFileDialog1.FileName;
               StreamWriter sw = new StreamWriter(fName);
               sw.Write(txtContent.Text);
               //sw.Flush();             
               txtContent.SelectedText = "";
               MessageBox.Show("Saved and\nNew File opened");
           }
           else
           {
               MessageBox.Show("New File opened");
           }
        }

        private void selectALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.SelectAll();
        }
        
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtContent.Text, new Font("Times New Romans", 14),Brushes.Black,new PointF(100,100));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cuttext = txtContent.SelectedText;
            Clipboard.SetText(cuttext);
            txtContent.SelectedText="";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String myText = Clipboard.GetText();
            txtContent.SelectedText = myText;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtContent.SelectedText);
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbtUs AbtObj = new AbtUs();
            AbtObj.Show();
        }

        
    }
}
