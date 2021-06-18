
namespace GameDev_Assignment2
{
    partial class Words
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
            this.animalButton = new System.Windows.Forms.Button();
            this.fruitsButton = new System.Windows.Forms.Button();
            this.objectsButton = new System.Windows.Forms.Button();
            this.bodyButton = new System.Windows.Forms.Button();
            this.coloursButton = new System.Windows.Forms.Button();
            this.objectbackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animalButton
            // 
            this.animalButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.obAnimal;
            this.animalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animalButton.Location = new System.Drawing.Point(288, 150);
            this.animalButton.Name = "animalButton";
            this.animalButton.Size = new System.Drawing.Size(75, 75);
            this.animalButton.TabIndex = 0;
            this.animalButton.UseVisualStyleBackColor = true;
            // 
            // fruitsButton
            // 
            this.fruitsButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.obApple;
            this.fruitsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fruitsButton.Location = new System.Drawing.Point(411, 150);
            this.fruitsButton.Name = "fruitsButton";
            this.fruitsButton.Size = new System.Drawing.Size(75, 75);
            this.fruitsButton.TabIndex = 1;
            this.fruitsButton.UseVisualStyleBackColor = true;
            // 
            // objectsButton
            // 
            this.objectsButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.obObjects;
            this.objectsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.objectsButton.Location = new System.Drawing.Point(533, 150);
            this.objectsButton.Name = "objectsButton";
            this.objectsButton.Size = new System.Drawing.Size(75, 75);
            this.objectsButton.TabIndex = 2;
            this.objectsButton.UseVisualStyleBackColor = true;
            // 
            // bodyButton
            // 
            this.bodyButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.obBody;
            this.bodyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bodyButton.Location = new System.Drawing.Point(336, 256);
            this.bodyButton.Name = "bodyButton";
            this.bodyButton.Size = new System.Drawing.Size(75, 75);
            this.bodyButton.TabIndex = 3;
            this.bodyButton.UseVisualStyleBackColor = true;
            // 
            // coloursButton
            // 
            this.coloursButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.obColour;
            this.coloursButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coloursButton.Location = new System.Drawing.Point(482, 256);
            this.coloursButton.Name = "coloursButton";
            this.coloursButton.Size = new System.Drawing.Size(75, 75);
            this.coloursButton.TabIndex = 4;
            this.coloursButton.UseVisualStyleBackColor = true;
            // 
            // objectbackButton
            // 
            this.objectbackButton.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.Back;
            this.objectbackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.objectbackButton.Location = new System.Drawing.Point(12, 654);
            this.objectbackButton.Name = "objectbackButton";
            this.objectbackButton.Size = new System.Drawing.Size(65, 45);
            this.objectbackButton.TabIndex = 5;
            this.objectbackButton.UseVisualStyleBackColor = true;
            this.objectbackButton.Click += new System.EventHandler(this.objectbackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::GameDev_Assignment2.Properties.Resources.LearnWords;
            this.label1.Location = new System.Drawing.Point(318, 57);
            this.label1.MaximumSize = new System.Drawing.Size(250, 50);
            this.label1.MinimumSize = new System.Drawing.Size(250, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 50);
            this.label1.TabIndex = 6;
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameDev_Assignment2.Properties.Resources.IMG_20210615_WA0015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectbackButton);
            this.Controls.Add(this.coloursButton);
            this.Controls.Add(this.bodyButton);
            this.Controls.Add(this.objectsButton);
            this.Controls.Add(this.fruitsButton);
            this.Controls.Add(this.animalButton);
            this.Name = "Words";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button animalButton;
        private System.Windows.Forms.Button fruitsButton;
        private System.Windows.Forms.Button objectsButton;
        private System.Windows.Forms.Button bodyButton;
        private System.Windows.Forms.Button coloursButton;
        private System.Windows.Forms.Button objectbackButton;
        private System.Windows.Forms.Label label1;
    }
}