using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Textor
{
    public partial class FindReplaceForm : Form
    {
        public FindReplaceForm()
        {
            InitializeComponent();
        }
        private void FindReplaceForm_Shown(object sender, EventArgs e)
        {
            FindTextbox.Focus();
        }

        int findCutLength = 0; 

        private void FindTextbox_TextChanged(object sender, EventArgs e) 
        {
            findCutLength = 0;
        }

        private void ReplaceTextbox_TextChanged(object sender, EventArgs e) 
        {
            findCutLength = 0;
        }

        private void RegisterCheckbox_CheckStateChanged(object sender, EventArgs e) 
        {
            findCutLength = 0;
        }

        private void FindReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            findCutLength = 0;
        }

        private void FindButton_Click(object sender, EventArgs e) 
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (RegisterCheckbox.CheckState == CheckState.Checked)
                {
                    Textwork.FindTextBox(ref main.TextBox1, FindTextbox.Text, ref findCutLength, true);
                }
                else
                {
                    Textwork.FindTextBox(ref main.TextBox1, FindTextbox.Text, ref findCutLength, false);
                }
            }
        }

        private void ReplaceButton_Click(object sender, EventArgs e) 
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (RegisterCheckbox.CheckState == CheckState.Checked)
                {
                    Textwork.ReplaceTextBox(ref main.TextBox1, FindTextbox.Text, ReplaceTextbox.Text, ref findCutLength, true);
                }
                else
                {
                    Textwork.ReplaceTextBox(ref main.TextBox1, FindTextbox.Text, ReplaceTextbox.Text, ref findCutLength, false);
                }
            }
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e) 
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                if (RegisterCheckbox.CheckState == CheckState.Checked)
                {
                    Textwork.ReplaceAllTextBox(ref main.TextBox1, FindTextbox.Text, ReplaceTextbox.Text, true);
                }
                else
                {
                    Textwork.ReplaceAllTextBox(ref main.TextBox1, FindTextbox.Text, ReplaceTextbox.Text, false);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
