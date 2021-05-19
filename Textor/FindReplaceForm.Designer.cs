
namespace Textor
{
    partial class FindReplaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindTextbox = new System.Windows.Forms.TextBox();
            this.ReplaceTextbox = new System.Windows.Forms.TextBox();
            this.RegisterCheckbox = new System.Windows.Forms.CheckBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.ReplaceAllButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Replace with";
            // 
            // FindTextbox
            // 
            this.FindTextbox.Location = new System.Drawing.Point(100, 25);
            this.FindTextbox.Name = "FindTextbox";
            this.FindTextbox.Size = new System.Drawing.Size(315, 23);
            this.FindTextbox.TabIndex = 2;
            this.FindTextbox.TextChanged += new System.EventHandler(this.FindTextbox_TextChanged);
            // 
            // ReplaceTextbox
            // 
            this.ReplaceTextbox.Location = new System.Drawing.Point(100, 60);
            this.ReplaceTextbox.Name = "ReplaceTextbox";
            this.ReplaceTextbox.Size = new System.Drawing.Size(315, 23);
            this.ReplaceTextbox.TabIndex = 3;
            this.ReplaceTextbox.TextChanged += new System.EventHandler(this.ReplaceTextbox_TextChanged);
            // 
            // RegisterCheckbox
            // 
            this.RegisterCheckbox.AutoSize = true;
            this.RegisterCheckbox.Location = new System.Drawing.Point(20, 95);
            this.RegisterCheckbox.Name = "RegisterCheckbox";
            this.RegisterCheckbox.Size = new System.Drawing.Size(119, 19);
            this.RegisterCheckbox.TabIndex = 4;
            this.RegisterCheckbox.Text = "Register sensetive";
            this.RegisterCheckbox.UseVisualStyleBackColor = true;
            this.RegisterCheckbox.CheckStateChanged += new System.EventHandler(this.RegisterCheckbox_CheckStateChanged);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(20, 130);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(95, 25);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find next";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(120, 130);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(95, 25);
            this.ReplaceButton.TabIndex = 6;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // ReplaceAllButton
            // 
            this.ReplaceAllButton.Location = new System.Drawing.Point(220, 130);
            this.ReplaceAllButton.Name = "ReplaceAllButton";
            this.ReplaceAllButton.Size = new System.Drawing.Size(95, 25);
            this.ReplaceAllButton.TabIndex = 7;
            this.ReplaceAllButton.Text = "Replace all";
            this.ReplaceAllButton.UseVisualStyleBackColor = true;
            this.ReplaceAllButton.Click += new System.EventHandler(this.ReplaceAllButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(320, 130);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(95, 25);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FindReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 176);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ReplaceAllButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.RegisterCheckbox);
            this.Controls.Add(this.ReplaceTextbox);
            this.Controls.Add(this.FindTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindReplaceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find and replace";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FindReplaceForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FindTextbox;
        private System.Windows.Forms.TextBox ReplaceTextbox;
        private System.Windows.Forms.CheckBox RegisterCheckbox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button ReplaceAllButton;
        private System.Windows.Forms.Button CancelButton;
    }
}