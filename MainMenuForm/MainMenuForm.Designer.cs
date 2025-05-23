﻿namespace MainMenuForm
{
    partial class MainMenuForm
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
            this.MMNewGameButton = new System.Windows.Forms.Button();
            this.MMLoadGameButton = new System.Windows.Forms.Button();
            this.MMExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MMNewGameButton
            // 
            this.MMNewGameButton.Location = new System.Drawing.Point(87, 87);
            this.MMNewGameButton.Name = "MMNewGameButton";
            this.MMNewGameButton.Size = new System.Drawing.Size(212, 23);
            this.MMNewGameButton.TabIndex = 0;
            this.MMNewGameButton.Text = "New Game";
            this.MMNewGameButton.UseVisualStyleBackColor = true;
            this.MMNewGameButton.Click += new System.EventHandler(this.MMNewGameButton_Click);
            // 
            // MMLoadGameButton
            // 
            this.MMLoadGameButton.Location = new System.Drawing.Point(87, 116);
            this.MMLoadGameButton.Name = "MMLoadGameButton";
            this.MMLoadGameButton.Size = new System.Drawing.Size(212, 23);
            this.MMLoadGameButton.TabIndex = 1;
            this.MMLoadGameButton.Text = "Load Game";
            this.MMLoadGameButton.UseVisualStyleBackColor = true;
            this.MMLoadGameButton.Click += new System.EventHandler(this.MMLoadGameButton_Click);
            // 
            // MMExitButton
            // 
            this.MMExitButton.Location = new System.Drawing.Point(87, 382);
            this.MMExitButton.Name = "MMExitButton";
            this.MMExitButton.Size = new System.Drawing.Size(212, 23);
            this.MMExitButton.TabIndex = 2;
            this.MMExitButton.Text = "Exit";
            this.MMExitButton.UseVisualStyleBackColor = true;
            this.MMExitButton.Click += new System.EventHandler(this.MMExitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Fortress";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MMExitButton);
            this.Controls.Add(this.MMLoadGameButton);
            this.Controls.Add(this.MMNewGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MMNewGameButton;
        private System.Windows.Forms.Button MMLoadGameButton;
        private System.Windows.Forms.Button MMExitButton;
        private System.Windows.Forms.Label label1;
    }
}

