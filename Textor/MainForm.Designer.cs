
namespace Textor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenuTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LinesStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LinesStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.FontDialog1 = new System.Windows.Forms.FontDialog();
            this.StripMenu.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.FormatMenu,
            this.StatusMenu});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(800, 24);
            this.StripMenu.TabIndex = 0;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuNew,
            this.FileMenuOpen,
            this.FileMenuSave,
            this.FileMenuSaveAs,
            this.FileMenuExit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // FileMenuNew
            // 
            this.FileMenuNew.Name = "FileMenuNew";
            this.FileMenuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FileMenuNew.Size = new System.Drawing.Size(191, 22);
            this.FileMenuNew.Text = "New";
            this.FileMenuNew.Click += new System.EventHandler(this.FileMenuNew_Click);
            // 
            // FileMenuOpen
            // 
            this.FileMenuOpen.Name = "FileMenuOpen";
            this.FileMenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileMenuOpen.Size = new System.Drawing.Size(191, 22);
            this.FileMenuOpen.Text = "Open";
            this.FileMenuOpen.Click += new System.EventHandler(this.FileMenuOpen_Click);
            // 
            // FileMenuSave
            // 
            this.FileMenuSave.Name = "FileMenuSave";
            this.FileMenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileMenuSave.Size = new System.Drawing.Size(191, 22);
            this.FileMenuSave.Text = "Save";
            this.FileMenuSave.Click += new System.EventHandler(this.FileMenuSave_Click);
            // 
            // FileMenuSaveAs
            // 
            this.FileMenuSaveAs.Name = "FileMenuSaveAs";
            this.FileMenuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.FileMenuSaveAs.Size = new System.Drawing.Size(191, 22);
            this.FileMenuSaveAs.Text = "Save as";
            this.FileMenuSaveAs.Click += new System.EventHandler(this.FileMenuSaveAs_Click);
            // 
            // FileMenuExit
            // 
            this.FileMenuExit.Name = "FileMenuExit";
            this.FileMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileMenuExit.Size = new System.Drawing.Size(191, 22);
            this.FileMenuExit.Text = "Exit";
            this.FileMenuExit.Click += new System.EventHandler(this.FileMenuExit_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMenuUndo,
            this.EditMenuCut,
            this.EditMenuCopy,
            this.EditMenuPaste,
            this.EditMenuDelete,
            this.EditMenuFind,
            this.EditMenuSelectAll});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(39, 20);
            this.EditMenu.Text = "Edit";
            // 
            // EditMenuUndo
            // 
            this.EditMenuUndo.Name = "EditMenuUndo";
            this.EditMenuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.EditMenuUndo.Size = new System.Drawing.Size(162, 22);
            this.EditMenuUndo.Text = "Undo";
            this.EditMenuUndo.Click += new System.EventHandler(this.EditMenuUndo_Click);
            // 
            // EditMenuCut
            // 
            this.EditMenuCut.Name = "EditMenuCut";
            this.EditMenuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EditMenuCut.Size = new System.Drawing.Size(162, 22);
            this.EditMenuCut.Text = "Cut";
            this.EditMenuCut.Click += new System.EventHandler(this.EditMenuCut_Click);
            // 
            // EditMenuCopy
            // 
            this.EditMenuCopy.Name = "EditMenuCopy";
            this.EditMenuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EditMenuCopy.Size = new System.Drawing.Size(162, 22);
            this.EditMenuCopy.Text = "Copy";
            this.EditMenuCopy.Click += new System.EventHandler(this.EditMenuCopy_Click);
            // 
            // EditMenuPaste
            // 
            this.EditMenuPaste.Name = "EditMenuPaste";
            this.EditMenuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.EditMenuPaste.Size = new System.Drawing.Size(162, 22);
            this.EditMenuPaste.Text = "Paste";
            this.EditMenuPaste.Click += new System.EventHandler(this.EditMenuPaste_Click);
            // 
            // EditMenuDelete
            // 
            this.EditMenuDelete.Name = "EditMenuDelete";
            this.EditMenuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.EditMenuDelete.Size = new System.Drawing.Size(162, 22);
            this.EditMenuDelete.Text = "Delete";
            this.EditMenuDelete.Click += new System.EventHandler(this.EditMenuDelete_Click);
            // 
            // EditMenuFind
            // 
            this.EditMenuFind.Name = "EditMenuFind";
            this.EditMenuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.EditMenuFind.Size = new System.Drawing.Size(162, 22);
            this.EditMenuFind.Text = "Find";
            this.EditMenuFind.Click += new System.EventHandler(this.EditMenuFind_Click);
            // 
            // EditMenuSelectAll
            // 
            this.EditMenuSelectAll.Name = "EditMenuSelectAll";
            this.EditMenuSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.EditMenuSelectAll.Size = new System.Drawing.Size(162, 22);
            this.EditMenuSelectAll.Text = "Select all";
            this.EditMenuSelectAll.Click += new System.EventHandler(this.EditMenuSelectAll_Click);
            // 
            // FormatMenu
            // 
            this.FormatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatMenuTransfer,
            this.FormatMenuFont});
            this.FormatMenu.Name = "FormatMenu";
            this.FormatMenu.Size = new System.Drawing.Size(57, 20);
            this.FormatMenu.Text = "Format";
            // 
            // FormatMenuTransfer
            // 
            this.FormatMenuTransfer.CheckOnClick = true;
            this.FormatMenuTransfer.Name = "FormatMenuTransfer";
            this.FormatMenuTransfer.Size = new System.Drawing.Size(116, 22);
            this.FormatMenuTransfer.Text = "Transfer";
            this.FormatMenuTransfer.CheckStateChanged += new System.EventHandler(this.FormatMenuTransfer_CheckStateChanged);
            // 
            // FormatMenuFont
            // 
            this.FormatMenuFont.Name = "FormatMenuFont";
            this.FormatMenuFont.Size = new System.Drawing.Size(116, 22);
            this.FormatMenuFont.Text = "Font";
            this.FormatMenuFont.Click += new System.EventHandler(this.FormatMenuFont_Click);
            // 
            // StatusMenu
            // 
            this.StatusMenu.Checked = true;
            this.StatusMenu.CheckOnClick = true;
            this.StatusMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusMenu.Name = "StatusMenu";
            this.StatusMenu.Size = new System.Drawing.Size(102, 20);
            this.StatusMenu.Text = "Show status bar";
            this.StatusMenu.CheckStateChanged += new System.EventHandler(this.StatusMenu_CheckStateChanged);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinesStatusLabel,
            this.LinesStatus,
            this.WordsStatusLabel,
            this.WordsStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // LinesStatusLabel
            // 
            this.LinesStatusLabel.Name = "LinesStatusLabel";
            this.LinesStatusLabel.Size = new System.Drawing.Size(95, 17);
            this.LinesStatusLabel.Text = "Number of lines:";
            // 
            // LinesStatus
            // 
            this.LinesStatus.Name = "LinesStatus";
            this.LinesStatus.Size = new System.Drawing.Size(13, 17);
            this.LinesStatus.Text = "0";
            // 
            // WordsStatusLabel
            // 
            this.WordsStatusLabel.Name = "WordsStatusLabel";
            this.WordsStatusLabel.Size = new System.Drawing.Size(103, 17);
            this.WordsStatusLabel.Text = "Number of words:";
            // 
            // WordsStatus
            // 
            this.WordsStatus.LinkVisited = true;
            this.WordsStatus.Name = "WordsStatus";
            this.WordsStatus.Size = new System.Drawing.Size(13, 17);
            this.WordsStatus.Text = "0";
            // 
            // TextBox1
            // 
            this.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox1.Location = new System.Drawing.Point(0, 24);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox1.Size = new System.Drawing.Size(800, 404);
            this.TextBox1.TabIndex = 2;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.StripMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuNew;
        private System.Windows.Forms.ToolStripMenuItem FileMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem FileMenuSave;
        private System.Windows.Forms.ToolStripMenuItem FileMenuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem FileMenuExit;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenuUndo;
        private System.Windows.Forms.ToolStripMenuItem EditMenuCut;
        private System.Windows.Forms.ToolStripMenuItem EditMenuCopy;
        private System.Windows.Forms.ToolStripMenuItem EditMenuPaste;
        private System.Windows.Forms.ToolStripMenuItem EditMenuDelete;
        private System.Windows.Forms.ToolStripMenuItem EditMenuFind;
        private System.Windows.Forms.ToolStripMenuItem EditMenuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem FormatMenu;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuTransfer;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuFont;
        private System.Windows.Forms.ToolStripMenuItem StatusMenu;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LinesStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LinesStatus;
        private System.Windows.Forms.ToolStripStatusLabel WordsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel WordsStatus;
        private System.Windows.Forms.FontDialog FontDialog1;
        public System.Windows.Forms.TextBox TextBox1;
    }
}

