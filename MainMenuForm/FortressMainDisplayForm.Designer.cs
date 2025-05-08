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
            this.CurrentDayLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NotificationsBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DownTownPicture = new System.Windows.Forms.PictureBox();
            this.StoragePicture = new System.Windows.Forms.PictureBox();
            this.EndDayButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TradingPortalPicture = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DownTownPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoragePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradingPortalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MoneyLabel.Location = new System.Drawing.Point(713, 49);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(60, 13);
            this.MoneyLabel.TabIndex = 0;
            this.MoneyLabel.Text = "Treasury: 0";
            // 
            // FortressNameLabel
            // 
            this.FortressNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FortressNameLabel.AutoSize = true;
            this.FortressNameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.FortressNameLabel.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FortressNameLabel.Location = new System.Drawing.Point(355, 9);
            this.FortressNameLabel.Name = "FortressNameLabel";
            this.FortressNameLabel.Size = new System.Drawing.Size(105, 27);
            this.FortressNameLabel.TabIndex = 2;
            this.FortressNameLabel.Text = "Fortress Name";
            // 
            // CurrentDayLabel
            // 
            this.CurrentDayLabel.AutoSize = true;
            this.CurrentDayLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CurrentDayLabel.Location = new System.Drawing.Point(713, 399);
            this.CurrentDayLabel.Name = "CurrentDayLabel";
            this.CurrentDayLabel.Size = new System.Drawing.Size(75, 13);
            this.CurrentDayLabel.TabIndex = 9;
            this.CurrentDayLabel.Text = "Current Day: 0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NotificationsBox
            // 
            this.NotificationsBox.FormattingEnabled = true;
            this.NotificationsBox.Location = new System.Drawing.Point(12, 49);
            this.NotificationsBox.Name = "NotificationsBox";
            this.NotificationsBox.Size = new System.Drawing.Size(157, 290);
            this.NotificationsBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Notifications";
            // 
            // DownTownPicture
            // 
            this.DownTownPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DownTownPicture.Location = new System.Drawing.Point(303, 314);
            this.DownTownPicture.Name = "DownTownPicture";
            this.DownTownPicture.Size = new System.Drawing.Size(265, 65);
            this.DownTownPicture.TabIndex = 17;
            this.DownTownPicture.TabStop = false;
            this.DownTownPicture.Click += new System.EventHandler(this.DownTownPicture_Click);
            // 
            // StoragePicture
            // 
            this.StoragePicture.BackColor = System.Drawing.Color.IndianRed;
            this.StoragePicture.Location = new System.Drawing.Point(376, 165);
            this.StoragePicture.Name = "StoragePicture";
            this.StoragePicture.Size = new System.Drawing.Size(67, 32);
            this.StoragePicture.TabIndex = 18;
            this.StoragePicture.TabStop = false;
            this.StoragePicture.Click += new System.EventHandler(this.StoragePicture_Click);
            // 
            // EndDayButton
            // 
            this.EndDayButton.BackColor = System.Drawing.SystemColors.Control;
            this.EndDayButton.Location = new System.Drawing.Point(716, 415);
            this.EndDayButton.Name = "EndDayButton";
            this.EndDayButton.Size = new System.Drawing.Size(75, 23);
            this.EndDayButton.TabIndex = 19;
            this.EndDayButton.Text = "End the day";
            this.EndDayButton.UseVisualStyleBackColor = false;
            this.EndDayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 459);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(812, 50);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(707, -7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 459);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // TradingPortalPicture
            // 
            this.TradingPortalPicture.BackColor = System.Drawing.Color.ForestGreen;
            this.TradingPortalPicture.Location = new System.Drawing.Point(528, 272);
            this.TradingPortalPicture.Name = "TradingPortalPicture";
            this.TradingPortalPicture.Size = new System.Drawing.Size(119, 36);
            this.TradingPortalPicture.TabIndex = 23;
            this.TradingPortalPicture.TabStop = false;
            this.TradingPortalPicture.Click += new System.EventHandler(this.TradingPortalPicture_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Storage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Trading Portal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Servants";
            // 
            // FortressMainDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TradingPortalPicture);
            this.Controls.Add(this.EndDayButton);
            this.Controls.Add(this.StoragePicture);
            this.Controls.Add(this.DownTownPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotificationsBox);
            this.Controls.Add(this.CurrentDayLabel);
            this.Controls.Add(this.FortressNameLabel);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FortressMainDisplayForm";
            this.Text = "Your Fortress";
            ((System.ComponentModel.ISupportInitialize)(this.DownTownPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoragePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TradingPortalPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MoneyLabel;
        private System.Windows.Forms.Label FortressNameLabel;
        private System.Windows.Forms.Label CurrentDayLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox NotificationsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox DownTownPicture;
        private System.Windows.Forms.PictureBox StoragePicture;
        private System.Windows.Forms.Button EndDayButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox TradingPortalPicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}