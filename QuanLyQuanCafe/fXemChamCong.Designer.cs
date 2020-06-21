namespace QuanLyQuanCafe
{
    partial class fXemChamCong
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
            this.dtgvXemChamCong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXemChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvXemChamCong
            // 
            this.dtgvXemChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvXemChamCong.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dtgvXemChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvXemChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvXemChamCong.Location = new System.Drawing.Point(0, 0);
            this.dtgvXemChamCong.Name = "dtgvXemChamCong";
            this.dtgvXemChamCong.Size = new System.Drawing.Size(682, 334);
            this.dtgvXemChamCong.TabIndex = 0;
            // 
            // fXemChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 334);
            this.Controls.Add(this.dtgvXemChamCong);
            this.Name = "fXemChamCong";
            this.Text = "fXemChamCong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvXemChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvXemChamCong;
    }
}