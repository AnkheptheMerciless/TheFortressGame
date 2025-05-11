namespace MainMenuForm
{
    partial class ManufactoryForm
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
            this.StructsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DaysToBuildLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GoldTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WoodTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StoneTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Here you can choose what to build or upgrade. Then you will need to wait.";
            // 
            // StructsComboBox
            // 
            this.StructsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StructsComboBox.FormattingEnabled = true;
            this.StructsComboBox.Location = new System.Drawing.Point(122, 41);
            this.StructsComboBox.Name = "StructsComboBox";
            this.StructsComboBox.Size = new System.Drawing.Size(328, 21);
            this.StructsComboBox.TabIndex = 1;
            this.StructsComboBox.SelectedIndexChanged += new System.EventHandler(this.StructsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Structures:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Necessary resources: ";
            // 
            // DaysToBuildLabel
            // 
            this.DaysToBuildLabel.AutoSize = true;
            this.DaysToBuildLabel.Location = new System.Drawing.Point(12, 125);
            this.DaysToBuildLabel.Name = "DaysToBuildLabel";
            this.DaysToBuildLabel.Size = new System.Drawing.Size(80, 13);
            this.DaysToBuildLabel.TabIndex = 4;
            this.DaysToBuildLabel.Text = "Days to build: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Build!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gold:";
            // 
            // GoldTextBox
            // 
            this.GoldTextBox.Location = new System.Drawing.Point(122, 93);
            this.GoldTextBox.Name = "GoldTextBox";
            this.GoldTextBox.ReadOnly = true;
            this.GoldTextBox.Size = new System.Drawing.Size(40, 20);
            this.GoldTextBox.TabIndex = 7;
            this.GoldTextBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Wood:";
            // 
            // WoodTextBox
            // 
            this.WoodTextBox.Location = new System.Drawing.Point(222, 93);
            this.WoodTextBox.Name = "WoodTextBox";
            this.WoodTextBox.ReadOnly = true;
            this.WoodTextBox.Size = new System.Drawing.Size(40, 20);
            this.WoodTextBox.TabIndex = 9;
            this.WoodTextBox.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stone:";
            // 
            // StoneTextBox
            // 
            this.StoneTextBox.Location = new System.Drawing.Point(323, 93);
            this.StoneTextBox.Name = "StoneTextBox";
            this.StoneTextBox.ReadOnly = true;
            this.StoneTextBox.Size = new System.Drawing.Size(40, 20);
            this.StoneTextBox.TabIndex = 11;
            this.StoneTextBox.Text = "0";
            // 
            // ManufactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 186);
            this.Controls.Add(this.StoneTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WoodTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GoldTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DaysToBuildLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StructsComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ManufactoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManufactoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StructsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DaysToBuildLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GoldTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WoodTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StoneTextBox;
    }
}