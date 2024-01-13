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

namespace lab2_q1_notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); 
            dlg.Title = "Open";
           /* dlg.ShowDialog();
            string fName = dlg.FileName;
            StreamReader sr = new StreamReader(fName);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();*/
            if (dlg.ShowDialog() == DialogResult.OK)
                richTextBox1.Text = dlg.FileName;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
           /* saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName; 
            StreamWriter sw = new StreamWriter(fName); 
            sw.Write(richTextBox1.Text);
            sw.Flush();
            sw.Close();*/
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog(); 
            fd.Font = richTextBox1.SelectionFont;
            fd.Color = richTextBox1.SelectionColor; 
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font; richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
         /*   PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;*/
            //Call ShowDialog  
            if (printDlg.ShowDialog() == DialogResult.OK) ;  
                
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            fd.Color = richTextBox1.SelectionColor;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = fd.Color;
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Ritika Salimath");
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
    }
}
