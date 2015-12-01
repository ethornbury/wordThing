using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //need this when going outside program


namespace WordPad
{
    public partial class Emer : Form
    {
        public Emer()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        //what the fuck??
        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //class openfile
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open file for Emer";
            ofd.Filter = "Text filez (*.txt)|*.txt|All filez (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                //streams in file in case its huge
  
            }

            this.Text = ofd.FileName; //referring to the class we are working in

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save filez";
            sfd.Filter = "Text filez (*.txt)|*.txt|All filez (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rtb.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = sfd.FileName;

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDia.ShowDialog();
        }

        private void pageSetUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDia.ShowDialog();
            // go to design tray and link the printDoc to the PageSetUp for this section to work and not throw error

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            // pick up default settings that I have created on set up
            fd.Font = rtb.Font;  //microsoft sans serif 11pt
            fd.ShowDialog();
            rtb.Font = fd.Font;  //rtb is what is on the rich text box and now changed to font from dialog box


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();


        }


        // the context menu
        //link the context menu in the NotifyIcon in the design tray
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
