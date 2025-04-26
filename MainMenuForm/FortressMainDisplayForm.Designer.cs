namespace MainMenuForm
{
    partial class FortressMainDisplayForm
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
            this.components = new System.ComponentModel.Container();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.FortressNameLabel = new System.Windows.Forms.Label();
            this.MoneyShower = new System.Windows.Forms.NumericUpDown();
            this.DayProgressBar = new System.Windows.Forms.ProgressBar();
            this.DayProgressLable = new System.Windows.Forms.Label();
            this.DSpeedDownButton = new System.Windows.Forms.Button();
            this.DSpeedUpButton = new System.Windows.Forms.Button();
            this.DaySpeedLabel = new System.Windows.Forms.Label();
            this.CurrentDayLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DaySpeedStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyShower)).BeginInit();
            this.SuspendLayout();
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Location = new System.Drawing.Point(721, 402);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(42, 13);
            this.MoneyLabel.TabIndex = 0;
            this.MoneyLabel.Text = "Money:";
            // 
            // FortressNameLabel
            // 
            this.FortressNameLabel.AutoSize = true;
            this.FortressNameLabel.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FortressNameLabel.Location = new System.Drawing.Point(348, 9);
            this.FortressNameLabel.Name = "FortressNameLabel";
            this.FortressNameLabel.Size = new System.Drawing.Size(105, 27);
            this.FortressNameLabel.TabIndex = 2;
            this.FortressNameLabel.Text = "Fortress Name";
            // 
            // MoneyShower
            // 
            this.MoneyShower.Location = new System.Drawing.Point(724, 418);
            this.MoneyShower.Name = "MoneyShower";
            this.MoneyShower.Size = new System.Drawing.Size(64, 20);
            this.MoneyShower.TabIndex = 3;
            // 
            // DayProgressBar
            // 
            this.DayProgressBar.Location = new System.Drawing.Point(91, 418);
            this.DayProgressBar.Maximum = 24;
            this.DayProgressBar.Name = "DayProgressBar";
            this.DayProgressBar.Size = new System.Drawing.Size(86, 23);
            this.DayProgressBar.TabIndex = 4;
            // 
            // DayProgressLable
            // 
            this.DayProgressLable.AutoSize = true;
            this.DayProgressLable.Location = new System.Drawing.Point(12, 420);
            this.DayProgressLable.Name = "DayProgressLable";
            this.DayProgressLable.Size = new System.Drawing.Size(73, 13);
            this.DayProgressLable.TabIndex = 5;
            this.DayProgressLable.Text = "Day Progress:";
            // 
            // DSpeedDownButton
            // 
            this.DSpeedDownButton.Location = new System.Drawing.Point(90, 391);
            this.DSpeedDownButton.Name = "DSpeedDownButton";
            this.DSpeedDownButton.Size = new System.Drawing.Size(24, 24);
            this.DSpeedDownButton.TabIndex = 6;
            this.DSpeedDownButton.Text = "<";
            this.DSpeedDownButton.UseVisualStyleBackColor = true;
            this.DSpeedDownButton.Click += new System.EventHandler(this.DSpeedDownButton_Click);
            // 
            // DSpeedUpButton
            // 
            this.DSpeedUpButton.Location = new System.Drawing.Point(154, 391);
            this.DSpeedUpButton.Name = "DSpeedUpButton";
            this.DSpeedUpButton.Size = new System.Drawing.Size(24, 24);
            this.DSpeedUpButton.TabIndex = 7;
            this.DSpeedUpButton.Text = ">";
            this.DSpeedUpButton.UseVisualStyleBackColor = true;
            this.DSpeedUpButton.Click += new System.EventHandler(this.DSpeedUpButton_Click);
            // 
            // DaySpeedLabel
            // 
            this.DaySpeedLabel.AutoSize = true;
            this.DaySpeedLabel.Location = new System.Drawing.Point(12, 371);
            this.DaySpeedLabel.Name = "DaySpeedLabel";
            this.DaySpeedLabel.Size = new System.Drawing.Size(63, 13);
            this.DaySpeedLabel.TabIndex = 8;
            this.DaySpeedLabel.Text = "Day Speed:";
            // 
            // CurrentDayLabel
            // 
            this.CurrentDayLabel.AutoSize = true;
            this.CurrentDayLabel.Location = new System.Drawing.Point(12, 347);
            this.CurrentDayLabel.Name = "CurrentDayLabel";
            this.CurrentDayLabel.Size = new System.Drawing.Size(66, 13);
            this.CurrentDayLabel.TabIndex = 9;
            this.CurrentDayLabel.Text = "Current Day:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 368);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            // 
            // DaySpeedStop
            // 
            this.DaySpeedStop.Location = new System.Drawing.Point(122, 391);
            this.DaySpeedStop.Name = "DaySpeedStop";
            this.DaySpeedStop.Size = new System.Drawing.Size(24, 24);
            this.DaySpeedStop.TabIndex = 13;
            this.DaySpeedStop.Text = "| |";
            this.DaySpeedStop.UseVisualStyleBackColor = true;
            this.DaySpeedStop.Click += new System.EventHandler(this.DaySpeedStop_Click);
            // 
            // FortressMainDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DaySpeedStop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CurrentDayLabel);
            this.Controls.Add(this.DaySpeedLabel);
            this.Controls.Add(this.DSpeedUpButton);
            this.Controls.Add(this.DSpeedDownButton);
            this.Controls.Add(this.DayProgressLable);
            this.Controls.Add(this.DayProgressBar);
            this.Controls.Add(this.MoneyShower);
            this.Controls.Add(this.FortressNameLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Name = "FortressMainDisplayForm";
            this.Text = "Your Fortress";
            ((System.ComponentModel.ISupportInitialize)(this.MoneyShower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label FortressNameLabel;
        private System.Windows.Forms.NumericUpDown MoneyShower;
        private System.Windows.Forms.ProgressBar DayProgressBar;
        private System.Windows.Forms.Label DayProgressLable;
        private System.Windows.Forms.Button DSpeedDownButton;
        private System.Windows.Forms.Button DSpeedUpButton;
        private System.Windows.Forms.Label DaySpeedLabel;
        private System.Windows.Forms.Label CurrentDayLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DaySpeedStop;
    }
}