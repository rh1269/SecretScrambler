﻿namespace SecretScrambler
{
    partial class NoteWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteWindow));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opennoEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savenormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptCurrentWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptCurrentWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptAndOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNewIVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteTextBox1 = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encryptionToolStripMenuItem1,
            this.encryptionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MainMenuStrip.Size = new System.Drawing.Size(625, 24);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.opennoEncryptionToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.savenormalToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // opennoEncryptionToolStripMenuItem
            // 
            this.opennoEncryptionToolStripMenuItem.Name = "opennoEncryptionToolStripMenuItem";
            this.opennoEncryptionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.opennoEncryptionToolStripMenuItem.Text = "Open";
            this.opennoEncryptionToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // savenormalToolStripMenuItem
            // 
            this.savenormalToolStripMenuItem.Name = "savenormalToolStripMenuItem";
            this.savenormalToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.savenormalToolStripMenuItem.Text = "Save As...";
            this.savenormalToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // encryptionToolStripMenuItem1
            // 
            this.encryptionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptCurrentWindowToolStripMenuItem,
            this.decryptCurrentWindowToolStripMenuItem});
            this.encryptionToolStripMenuItem1.Name = "encryptionToolStripMenuItem1";
            this.encryptionToolStripMenuItem1.Size = new System.Drawing.Size(76, 22);
            this.encryptionToolStripMenuItem1.Text = "Encryption";
            // 
            // encryptCurrentWindowToolStripMenuItem
            // 
            this.encryptCurrentWindowToolStripMenuItem.Name = "encryptCurrentWindowToolStripMenuItem";
            this.encryptCurrentWindowToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.encryptCurrentWindowToolStripMenuItem.Text = "Encrypt Current Text";
            this.encryptCurrentWindowToolStripMenuItem.Click += new System.EventHandler(this.encryptCurrentWindowToolStripMenuItem_Click);
            // 
            // decryptCurrentWindowToolStripMenuItem
            // 
            this.decryptCurrentWindowToolStripMenuItem.Name = "decryptCurrentWindowToolStripMenuItem";
            this.decryptCurrentWindowToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.decryptCurrentWindowToolStripMenuItem.Text = "Decrypt Current Text";
            this.decryptCurrentWindowToolStripMenuItem.Click += new System.EventHandler(this.decryptCurrentWindowToolStripMenuItem_Click);
            // 
            // encryptionToolStripMenuItem
            // 
            this.encryptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptSaveToolStripMenuItem,
            this.decryptAndOpenToolStripMenuItem,
            this.generateNewIVToolStripMenuItem});
            this.encryptionToolStripMenuItem.Name = "encryptionToolStripMenuItem";
            this.encryptionToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.encryptionToolStripMenuItem.Text = "Experimental";
            // 
            // encryptSaveToolStripMenuItem
            // 
            this.encryptSaveToolStripMenuItem.Name = "encryptSaveToolStripMenuItem";
            this.encryptSaveToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.encryptSaveToolStripMenuItem.Text = "Encrypt And Save";
            this.encryptSaveToolStripMenuItem.Click += new System.EventHandler(this.SaveEncrypt_Click);
            // 
            // decryptAndOpenToolStripMenuItem
            // 
            this.decryptAndOpenToolStripMenuItem.Name = "decryptAndOpenToolStripMenuItem";
            this.decryptAndOpenToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.decryptAndOpenToolStripMenuItem.Text = "Decrypt And Open";
            this.decryptAndOpenToolStripMenuItem.Click += new System.EventHandler(this.DecryptOpen_Click);
            // 
            // generateNewIVToolStripMenuItem
            // 
            this.generateNewIVToolStripMenuItem.Name = "generateNewIVToolStripMenuItem";
            this.generateNewIVToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.generateNewIVToolStripMenuItem.Text = "Generate New IV";
            this.generateNewIVToolStripMenuItem.Click += new System.EventHandler(this.generateNewIVToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // NoteTextBox1
            // 
            this.NoteTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox1.Location = new System.Drawing.Point(12, 27);
            this.NoteTextBox1.Multiline = true;
            this.NoteTextBox1.Name = "NoteTextBox1";
            this.NoteTextBox1.Size = new System.Drawing.Size(601, 416);
            this.NoteTextBox1.TabIndex = 2;
            // 
            // NoteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 455);
            this.Controls.Add(this.NoteTextBox1);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteWindow";
            this.Text = "SecretScrambler";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opennoEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savenormalToolStripMenuItem;
        private System.Windows.Forms.TextBox NoteTextBox1;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptAndOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encryptCurrentWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptCurrentWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateNewIVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

