﻿
namespace GameDev_Assignment2
{
    partial class Form4
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.alphabetBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.TestSpelling;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(312, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 55);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.TestWords;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(312, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 55);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alphabetBackButton
            // 
            this.alphabetBackButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.Back;
            this.alphabetBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alphabetBackButton.Location = new System.Drawing.Point(12, 654);
            this.alphabetBackButton.Name = "alphabetBackButton";
            this.alphabetBackButton.Size = new System.Drawing.Size(65, 45);
            this.alphabetBackButton.TabIndex = 28;
            this.alphabetBackButton.UseVisualStyleBackColor = true;
            this.alphabetBackButton.Click += new System.EventHandler(this.alphabetBackButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.IMG_20210615_WA0015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.alphabetBackButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button alphabetBackButton;
    }
}