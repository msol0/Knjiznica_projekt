namespace Knjižnica.Controls
{
    partial class Control_RentRecords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgRentRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRentRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Underline);
            this.lblRecords.Location = new System.Drawing.Point(35, 17);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(182, 26);
            this.lblRecords.TabIndex = 0;
            this.lblRecords.Text = "Evidencija dugovanja";
            // 
            // dgRentRecords
            // 
            this.dgRentRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRentRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgRentRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRentRecords.Location = new System.Drawing.Point(40, 65);
            this.dgRentRecords.Name = "dgRentRecords";
            this.dgRentRecords.RowHeadersWidth = 51;
            this.dgRentRecords.RowTemplate.Height = 24;
            this.dgRentRecords.Size = new System.Drawing.Size(712, 380);
            this.dgRentRecords.TabIndex = 1;
            // 
            // Control_RentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.dgRentRecords);
            this.Controls.Add(this.lblRecords);
            this.Name = "Control_RentRecords";
            this.Size = new System.Drawing.Size(792, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dgRentRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgRentRecords;
    }
}
