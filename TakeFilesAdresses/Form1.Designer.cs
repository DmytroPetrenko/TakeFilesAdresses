﻿namespace TakeFilesAdresses
{
    partial class Form1
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
            this.SelectRootFolderBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectRootFolderBtn
            // 
            this.SelectRootFolderBtn.Location = new System.Drawing.Point(174, 222);
            this.SelectRootFolderBtn.Name = "SelectRootFolderBtn";
            this.SelectRootFolderBtn.Size = new System.Drawing.Size(165, 23);
            this.SelectRootFolderBtn.TabIndex = 0;
            this.SelectRootFolderBtn.Text = "Выбор корневой папки";
            this.SelectRootFolderBtn.UseVisualStyleBackColor = true;
            this.SelectRootFolderBtn.Click += new System.EventHandler(this.SelectRootFolderBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(540, 139);
            this.textBox1.TabIndex = 1;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(454, 222);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(165, 23);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SelectRootFolderBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectRootFolderBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button StartBtn;
    }
}

