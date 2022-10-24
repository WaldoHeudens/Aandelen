namespace Les_8_3
{
    partial class AandelenForm
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
            this.aandelenDataGridView = new System.Windows.Forms.DataGridView();
            this.lblAandelen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aandelenDataGridView
            // 
            this.aandelenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aandelenDataGridView.Location = new System.Drawing.Point(12, 38);
            this.aandelenDataGridView.Name = "aandelenDataGridView";
            this.aandelenDataGridView.RowTemplate.Height = 25;
            this.aandelenDataGridView.Size = new System.Drawing.Size(554, 151);
            this.aandelenDataGridView.TabIndex = 1;
            this.aandelenDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aandelenDataGridView_RowsAdded);
            // 
            // lblAandelen
            // 
            this.lblAandelen.AutoSize = true;
            this.lblAandelen.Location = new System.Drawing.Point(12, 20);
            this.lblAandelen.Name = "lblAandelen";
            this.lblAandelen.Size = new System.Drawing.Size(57, 15);
            this.lblAandelen.TabIndex = 2;
            this.lblAandelen.Text = "Aandelen";
            // 
            // AandelenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAandelen);
            this.Controls.Add(this.aandelenDataGridView);
            this.Name = "AandelenForm";
            this.Text = "Werken met aandelen";
            this.Load += new System.EventHandler(this.AandelenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aandelenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView aandelenDataGridView;
        private Label lblAandelen;
    }
}