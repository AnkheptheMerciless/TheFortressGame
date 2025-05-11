namespace MainMenuForm
{
    partial class OverlordChambers
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServantComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ManaLabel = new System.Windows.Forms.Label();
            this.HungerLabel = new System.Windows.Forms.Label();
            this.HungerRateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rest for a while";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the servant: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Here you can choose one of your servants to \"rest\" with for a while. ";
            // 
            // ServantComboBox
            // 
            this.ServantComboBox.FormattingEnabled = true;
            this.ServantComboBox.Location = new System.Drawing.Point(126, 68);
            this.ServantComboBox.Name = "ServantComboBox";
            this.ServantComboBox.Size = new System.Drawing.Size(121, 21);
            this.ServantComboBox.TabIndex = 3;
            this.ServantComboBox.SelectedIndexChanged += new System.EventHandler(this.ServantComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "They will not work today and their hunger will rise but you\'ll gain some mana.";
            // 
            // ManaLabel
            // 
            this.ManaLabel.AutoSize = true;
            this.ManaLabel.Location = new System.Drawing.Point(15, 177);
            this.ManaLabel.Name = "ManaLabel";
            this.ManaLabel.Size = new System.Drawing.Size(69, 13);
            this.ManaLabel.TabIndex = 5;
            this.ManaLabel.Text = "Mana gain: 0";
            // 
            // HungerLabel
            // 
            this.HungerLabel.AutoSize = true;
            this.HungerLabel.Location = new System.Drawing.Point(15, 101);
            this.HungerLabel.Name = "HungerLabel";
            this.HungerLabel.Size = new System.Drawing.Size(138, 13);
            this.HungerLabel.TabIndex = 6;
            this.HungerLabel.Text = "Servant\'s current hunger:  0";
            // 
            // HungerRateLabel
            // 
            this.HungerRateLabel.AutoSize = true;
            this.HungerRateLabel.Location = new System.Drawing.Point(15, 126);
            this.HungerRateLabel.Name = "HungerRateLabel";
            this.HungerRateLabel.Size = new System.Drawing.Size(169, 13);
            this.HungerRateLabel.TabIndex = 7;
            this.HungerRateLabel.Text = "Servant will lose 0 point of hunger.";
            // 
            // OverlordChambers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 259);
            this.Controls.Add(this.HungerRateLabel);
            this.Controls.Add(this.HungerLabel);
            this.Controls.Add(this.ManaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServantComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OverlordChambers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overlord\'s Chambers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServantComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ManaLabel;
        private System.Windows.Forms.Label HungerLabel;
        private System.Windows.Forms.Label HungerRateLabel;
    }
}