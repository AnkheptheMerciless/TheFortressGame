namespace MainMenuForm
{
    partial class StorageViewForm
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
            this.StorageGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StorageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StorageGridView
            // 
            this.StorageGridView.AllowUserToAddRows = false;
            this.StorageGridView.AllowUserToDeleteRows = false;
            this.StorageGridView.AllowUserToResizeColumns = false;
            this.StorageGridView.AllowUserToResizeRows = false;
            this.StorageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageGridView.Location = new System.Drawing.Point(12, 12);
            this.StorageGridView.Name = "StorageGridView";
            this.StorageGridView.Size = new System.Drawing.Size(776, 426);
            this.StorageGridView.TabIndex = 0;
            // 
            // StorageViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StorageGridView);
            this.Name = "StorageViewForm";
            this.Text = "Storage";
            ((System.ComponentModel.ISupportInitialize)(this.StorageGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StorageGridView;
    }
}