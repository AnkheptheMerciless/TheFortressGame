namespace MainMenuForm
{
    partial class ServantsShowForm
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
            this.ServantsGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ServantsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ServantsGridView
            // 
            this.ServantsGridView.AllowUserToAddRows = false;
            this.ServantsGridView.AllowUserToDeleteRows = false;
            this.ServantsGridView.AllowUserToResizeColumns = false;
            this.ServantsGridView.AllowUserToResizeRows = false;
            this.ServantsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServantsGridView.Location = new System.Drawing.Point(13, 13);
            this.ServantsGridView.MultiSelect = false;
            this.ServantsGridView.Name = "ServantsGridView";
            this.ServantsGridView.ReadOnly = true;
            this.ServantsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServantsGridView.Size = new System.Drawing.Size(775, 392);
            this.ServantsGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Change Job";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServantsShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServantsGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServantsShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servants";
            ((System.ComponentModel.ISupportInitialize)(this.ServantsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServantsGridView;
        private System.Windows.Forms.Button button1;
    }
}