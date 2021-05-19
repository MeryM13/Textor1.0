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

namespace Textor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = Properties.Settings.Default.NewDocName + " - " + Properties.Settings.Default.ProgrammName;
        }
        public MainForm(string fileName) 
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
            {
                try
                {
                    string ProgrammName = Properties.Settings.Default.ProgrammName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file, Encoding.Default);
                    TextBox1.Text = reader.ReadToEnd();
                    reader.Close();
                    docPath = fileName;
                    tbChange = false;
                    this.Text = Path.GetFileName(fileName) + " — " + ProgrammName;
                    TextBox1.Select(0, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        bool tbChange = false;
        string docPath = "";

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = Properties.Settings.Default.FormWidth;
            this.Height = Properties.Settings.Default.FormHeight;
            TextBox1.Font = Properties.Settings.Default.TextFont;
            if (Properties.Settings.Default.StatusVisible == true)
            { StatusMenu.CheckState = CheckState.Checked; }
            else
            { StatusMenu.CheckState = CheckState.Unchecked; }
            if (Properties.Settings.Default.TextTransfer == true)
            { FormatMenuTransfer.CheckState = CheckState.Checked; }
            else
            { FormatMenuTransfer.CheckState = CheckState.Unchecked; }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            tbChange = true;
            Textwork.StatusAnalize(ref TextBox1, ref LinesStatus, ref WordsStatus);
            Textwork.mEditEnableds(ref TextBox1, ref EditMenuCopy, ref EditMenuCut, ref EditMenuDelete, ref EditMenuFind);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        Filework.SaveFile(ref TextBox1, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                    else if (docPath == "")
                    {
                        Filework.SaveAsFile(ref TextBox1, ref tbChange, ref docPath);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            Properties.Settings.Default.FormWidth = this.Width;
            Properties.Settings.Default.FormHeight = this.Height;
            Properties.Settings.Default.TextTransfer = TextBox1.WordWrap;
            Properties.Settings.Default.TextFont = TextBox1.Font;
            Properties.Settings.Default.StatusVisible = StatusStrip.Visible;
            Properties.Settings.Default.Save();
        }

        private void FileMenuNew_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед созданием нового?", "Создание документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        Filework.SaveFile(ref TextBox1, ref tbChange, ref docPath);
                        Filework.CreateFile(ref TextBox1, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        Filework.SaveAsFile(ref TextBox1, ref tbChange, ref docPath);
                        Filework.CreateFile(ref TextBox1, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    Filework.CreateFile(ref TextBox1, ref tbChange, ref docPath);
                }
            }
            else
            {
                Filework.CreateFile(ref TextBox1, ref tbChange, ref docPath);
            }
        }

        private void FileMenuOpen_Click(object sender, EventArgs e)
        {
            if (tbChange == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед открытием нового?", "Открытие документа", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (docPath != "")
                    {
                        Filework.SaveFile(ref TextBox1, ref tbChange, ref docPath);
                        Filework.OpenFile(ref TextBox1, ref tbChange, ref docPath);
                    }
                    else if (docPath == "")
                    {
                        Filework.SaveAsFile(ref TextBox1, ref tbChange, ref docPath);
                        Filework.OpenFile(ref TextBox1, ref tbChange, ref docPath);
                    }
                }
                else if (message == DialogResult.No)
                {
                    Filework.OpenFile(ref TextBox1, ref tbChange, ref docPath);
                }
                else
                {
                    return;
                }
            }
            else
            {
                Filework.OpenFile(ref TextBox1, ref tbChange, ref docPath);
            }
        }

        private void FileMenuSave_Click(object sender, EventArgs e)
        {
            if (docPath != "")
            {
                Filework.SaveFile(ref TextBox1, ref tbChange, ref docPath);
            }
            else
            {
                Filework.SaveAsFile(ref TextBox1, ref tbChange, ref docPath);
            }
        }

        private void FileMenuSaveAs_Click(object sender, EventArgs e)
        {
            Filework.SaveAsFile(ref TextBox1, ref tbChange, ref docPath);
        }

        private void FileMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EditMenuUndo_Click(object sender, EventArgs e)
        {
            TextBox1.Undo();
        }

        private void EditMenuCut_Click(object sender, EventArgs e)
        {
            if (TextBox1.SelectionLength > 0)
            {
                TextBox1.Cut();
            }
        }

        private void EditMenuCopy_Click(object sender, EventArgs e)
        {
            if (TextBox1.SelectionLength > 0)
            {
                TextBox1.Copy();
            }
        }

        private void EditMenuPaste_Click(object sender, EventArgs e)
        {
            TextBox1.Paste();
        }

        private void EditMenuDelete_Click(object sender, EventArgs e)
        {
            if (TextBox1.SelectionLength > 0)
            {
                TextBox1.SelectedText = "";
            }
        }

        private void EditMenuSelectAll_Click(object sender, EventArgs e)
        {
            TextBox1.SelectAll();
        }

        private void EditMenuFind_Click(object sender, EventArgs e)
        {
            FindReplaceForm findText = new FindReplaceForm();
            findText.Owner = this;
            findText.Show();
        }

        private void FormatMenuFont_Click(object sender, EventArgs e)
        {
            FontDialog1.Font = TextBox1.Font;
            DialogResult = FontDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                TextBox1.Font = FontDialog1.Font;
            }
        }

        private void FormatMenuTransfer_CheckStateChanged(object sender, EventArgs e)
        {
            if (FormatMenuTransfer.CheckState == CheckState.Checked)
            {
                TextBox1.WordWrap = true;
                TextBox1.ScrollBars = ScrollBars.Vertical;
                LinesStatusLabel.Visible = false;
                LinesStatus.Visible = false;
            }
            else
            {
                TextBox1.WordWrap = false;
                TextBox1.ScrollBars = ScrollBars.Both;
                LinesStatusLabel.Visible = true;
                LinesStatus.Visible = true;
            }
        }

        private void StatusMenu_CheckStateChanged(object sender, EventArgs e)
        {
            if (StatusMenu.CheckState == CheckState.Checked)
            {
                StatusStrip.Visible = true;
            }
            else
            {
                StatusStrip.Visible = false;
            }
        }
    }
}
