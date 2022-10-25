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
            this.btBewaar = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aandelenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aandelenDataGridView
            // 
            this.aandelenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aandelenDataGridView.Location = new System.Drawing.Point(12, 38);
            this.aandelenDataGridView.Name = "aandelenDataGridView";
            this.aandelenDataGridView.RowTemplate.Height = 25;
            this.aandelenDataGridView.Size = new System.Drawing.Size(579, 151);
            this.aandelenDataGridView.TabIndex = 1;
            this.aandelenDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.aandelenDataGridView_CellEndEdit);
            this.aandelenDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aandelenDataGridView_RowsAdded);
            this.aandelenDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.aandelenDataGridView_UserDeletingRow);
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
            // btBewaar
            // 
            this.btBewaar.Enabled = false;
            this.btBewaar.Location = new System.Drawing.Point(615, 38);
            this.btBewaar.Name = "btBewaar";
            this.btBewaar.Size = new System.Drawing.Size(133, 31);
            this.btBewaar.TabIndex = 3;
            this.btBewaar.Text = "Bewaar wijzigingen";
            this.btBewaar.UseVisualStyleBackColor = true;
            this.btBewaar.Click += new System.EventHandler(this.btBewaar_Click);
            // 
            // btUndo
            // 
            this.btUndo.Enabled = false;
            this.btUndo.Location = new System.Drawing.Point(615, 88);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(133, 31);
            this.btUndo.TabIndex = 4;
            this.btUndo.Text = "Ongedaan maken";
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // AandelenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.btUndo);
            this.Controls.Add(this.btBewaar);
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
        private Button btBewaar;
        private Button btUndo;
    }
}