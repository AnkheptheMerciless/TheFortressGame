namespace MainMenuForm
{
    partial class TradeForm
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
            this.StorageItemsBox = new System.Windows.Forms.ListBox();
            this.SoldItemsBox = new System.Windows.Forms.ListBox();
            this.FromLeftToRightSingle = new System.Windows.Forms.Button();
            this.FromLeftToRightAll = new System.Windows.Forms.Button();
            this.FromRightToLeftSingle = new System.Windows.Forms.Button();
            this.FromRightToLeftAll = new System.Windows.Forms.Button();
            this.SellButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelGain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StorageItemsBox
            // 
            this.StorageItemsBox.FormattingEnabled = true;
            this.StorageItemsBox.Location = new System.Drawing.Point(12, 51);
            this.StorageItemsBox.Name = "StorageItemsBox";
            this.StorageItemsBox.Size = new System.Drawing.Size(207, 316);
            this.StorageItemsBox.TabIndex = 0;
            // 
            // SoldItemsBox
            // 
            this.SoldItemsBox.FormattingEnabled = true;
            this.SoldItemsBox.Location = new System.Drawing.Point(300, 51);
            this.SoldItemsBox.Name = "SoldItemsBox";
            this.SoldItemsBox.Size = new System.Drawing.Size(207, 316);
            this.SoldItemsBox.TabIndex = 1;
            // 
            // FromLeftToRightSingle
            // 
            this.FromLeftToRightSingle.Location = new System.Drawing.Point(239, 91);
            this.FromLeftToRightSingle.Name = "FromLeftToRightSingle";
            this.FromLeftToRightSingle.Size = new System.Drawing.Size(45, 45);
            this.FromLeftToRightSingle.TabIndex = 2;
            this.FromLeftToRightSingle.Text = ">";
            this.FromLeftToRightSingle.UseVisualStyleBackColor = true;
            this.FromLeftToRightSingle.Click += new System.EventHandler(this.FromLeftToRightSingle_Click);
            // 
            // FromLeftToRightAll
            // 
            this.FromLeftToRightAll.Location = new System.Drawing.Point(239, 142);
            this.FromLeftToRightAll.Name = "FromLeftToRightAll";
            this.FromLeftToRightAll.Size = new System.Drawing.Size(45, 45);
            this.FromLeftToRightAll.TabIndex = 3;
            this.FromLeftToRightAll.Text = ">>";
            this.FromLeftToRightAll.UseVisualStyleBackColor = true;
            this.FromLeftToRightAll.Click += new System.EventHandler(this.FromLeftToRightAll_Click);
            // 
            // FromRightToLeftSingle
            // 
            this.FromRightToLeftSingle.Location = new System.Drawing.Point(239, 222);
            this.FromRightToLeftSingle.Name = "FromRightToLeftSingle";
            this.FromRightToLeftSingle.Size = new System.Drawing.Size(45, 45);
            this.FromRightToLeftSingle.TabIndex = 4;
            this.FromRightToLeftSingle.Text = "<";
            this.FromRightToLeftSingle.UseVisualStyleBackColor = true;
            this.FromRightToLeftSingle.Click += new System.EventHandler(this.FromRightToLeftSingle_Click);
            // 
            // FromRightToLeftAll
            // 
            this.FromRightToLeftAll.Location = new System.Drawing.Point(239, 273);
            this.FromRightToLeftAll.Name = "FromRightToLeftAll";
            this.FromRightToLeftAll.Size = new System.Drawing.Size(45, 45);
            this.FromRightToLeftAll.TabIndex = 5;
            this.FromRightToLeftAll.Text = "<<";
            this.FromRightToLeftAll.UseVisualStyleBackColor = true;
            this.FromRightToLeftAll.Click += new System.EventHandler(this.FromRightToLeftAll_Click);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(12, 399);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(495, 39);
            this.SellButton.TabIndex = 6;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FORTRESS\' STORAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FOR SALE";
            // 
            // LabelGain
            // 
            this.LabelGain.AutoSize = true;
            this.LabelGain.Location = new System.Drawing.Point(300, 374);
            this.LabelGain.Name = "LabelGain";
            this.LabelGain.Size = new System.Drawing.Size(72, 13);
            this.LabelGain.TabIndex = 9;
            this.LabelGain.Text = "You will gain: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "*Here you can sell products from your stocks.";
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelGain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.FromRightToLeftAll);
            this.Controls.Add(this.FromRightToLeftSingle);
            this.Controls.Add(this.FromLeftToRightAll);
            this.Controls.Add(this.FromLeftToRightSingle);
            this.Controls.Add(this.SoldItemsBox);
            this.Controls.Add(this.StorageItemsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TradeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StorageItemsBox;
        private System.Windows.Forms.ListBox SoldItemsBox;
        private System.Windows.Forms.Button FromLeftToRightSingle;
        private System.Windows.Forms.Button FromLeftToRightAll;
        private System.Windows.Forms.Button FromRightToLeftSingle;
        private System.Windows.Forms.Button FromRightToLeftAll;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelGain;
        private System.Windows.Forms.Label label3;
    }
}