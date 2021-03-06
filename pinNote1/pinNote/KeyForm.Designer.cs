﻿namespace SecretScrambler
{
    partial class keyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keyForm));
            this.EnterKeyMessage = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.keyButton = new System.Windows.Forms.Button();
            this.EncryptionSelectLabel = new System.Windows.Forms.Label();
            this.AESCheckbox = new System.Windows.Forms.CheckBox();
            this.TripleDESCheckbox = new System.Windows.Forms.CheckBox();
            this.HumbleCryptCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EnterKeyMessage
            // 
            this.EnterKeyMessage.AutoSize = true;
            this.EnterKeyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterKeyMessage.Location = new System.Drawing.Point(15, 116);
            this.EnterKeyMessage.Name = "EnterKeyMessage";
            this.EnterKeyMessage.Size = new System.Drawing.Size(180, 13);
            this.EnterKeyMessage.TabIndex = 0;
            this.EnterKeyMessage.Text = "Please provide your password.";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(18, 141);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(174, 20);
            this.keyBox.TabIndex = 1;
            // 
            // keyButton
            // 
            this.keyButton.Location = new System.Drawing.Point(18, 167);
            this.keyButton.Name = "keyButton";
            this.keyButton.Size = new System.Drawing.Size(174, 23);
            this.keyButton.TabIndex = 2;
            this.keyButton.Text = "Apply";
            this.keyButton.UseVisualStyleBackColor = true;
            this.keyButton.Click += new System.EventHandler(this.keyButton_Click);
            // 
            // EncryptionSelectLabel
            // 
            this.EncryptionSelectLabel.AutoSize = true;
            this.EncryptionSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncryptionSelectLabel.Location = new System.Drawing.Point(18, 13);
            this.EncryptionSelectLabel.Name = "EncryptionSelectLabel";
            this.EncryptionSelectLabel.Size = new System.Drawing.Size(184, 13);
            this.EncryptionSelectLabel.TabIndex = 3;
            this.EncryptionSelectLabel.Text = "Please select encryption types:";
            // 
            // AESCheckbox
            // 
            this.AESCheckbox.AutoSize = true;
            this.AESCheckbox.Checked = true;
            this.AESCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AESCheckbox.Location = new System.Drawing.Point(21, 30);
            this.AESCheckbox.Name = "AESCheckbox";
            this.AESCheckbox.Size = new System.Drawing.Size(47, 17);
            this.AESCheckbox.TabIndex = 4;
            this.AESCheckbox.Text = "AES";
            this.AESCheckbox.UseVisualStyleBackColor = true;
            // 
            // TripleDESCheckbox
            // 
            this.TripleDESCheckbox.AutoSize = true;
            this.TripleDESCheckbox.Location = new System.Drawing.Point(21, 54);
            this.TripleDESCheckbox.Name = "TripleDESCheckbox";
            this.TripleDESCheckbox.Size = new System.Drawing.Size(77, 17);
            this.TripleDESCheckbox.TabIndex = 5;
            this.TripleDESCheckbox.Text = "Triple DES";
            this.TripleDESCheckbox.UseVisualStyleBackColor = true;
            // 
            // HumbleCryptCheckbox
            // 
            this.HumbleCryptCheckbox.AutoSize = true;
            this.HumbleCryptCheckbox.Location = new System.Drawing.Point(21, 78);
            this.HumbleCryptCheckbox.Name = "HumbleCryptCheckbox";
            this.HumbleCryptCheckbox.Size = new System.Drawing.Size(86, 17);
            this.HumbleCryptCheckbox.TabIndex = 6;
            this.HumbleCryptCheckbox.Text = "HumbleCrypt";
            this.HumbleCryptCheckbox.UseVisualStyleBackColor = true;
            // 
            // keyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 202);
            this.Controls.Add(this.HumbleCryptCheckbox);
            this.Controls.Add(this.TripleDESCheckbox);
            this.Controls.Add(this.AESCheckbox);
            this.Controls.Add(this.EncryptionSelectLabel);
            this.Controls.Add(this.keyButton);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.EnterKeyMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "keyForm";
            this.Text = "Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterKeyMessage;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.Button keyButton;
        private System.Windows.Forms.Label EncryptionSelectLabel;
        private System.Windows.Forms.CheckBox AESCheckbox;
        private System.Windows.Forms.CheckBox TripleDESCheckbox;
        private System.Windows.Forms.CheckBox HumbleCryptCheckbox;
    }
}