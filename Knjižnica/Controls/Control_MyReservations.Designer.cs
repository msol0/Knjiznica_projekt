namespace Knjižnica.Controls
{
    partial class Control_MyReservations
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
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lblMyReservation = new System.Windows.Forms.Label();
            this.dgReservations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.AutoSize = true;
            this.btnReturnBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturnBook.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Location = new System.Drawing.Point(443, 296);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(99, 32);
            this.btnReturnBook.TabIndex = 12;
            this.btnReturnBook.Text = "Vrati knjigu";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // lblMyReservation
            // 
            this.lblMyReservation.AutoSize = true;
            this.lblMyReservation.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.lblMyReservation.Location = new System.Drawing.Point(-2, 0);
            this.lblMyReservation.Name = "lblMyReservation";
            this.lblMyReservation.Size = new System.Drawing.Size(165, 30);
            this.lblMyReservation.TabIndex = 11;
            this.lblMyReservation.Text = "Moje rezervacije:";
            // 
            // dgReservations
            // 
            this.dgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservations.Location = new System.Drawing.Point(3, 48);
            this.dgReservations.Name = "dgReservations";
            this.dgReservations.RowHeadersWidth = 51;
            this.dgReservations.RowTemplate.Height = 24;
            this.dgReservations.Size = new System.Drawing.Size(606, 225);
            this.dgReservations.TabIndex = 10;
            // 
            // Control_MyReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lblMyReservation);
            this.Controls.Add(this.dgReservations);
            this.Name = "Control_MyReservations";
            this.Size = new System.Drawing.Size(641, 342);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label lblMyReservation;
        private System.Windows.Forms.DataGridView dgReservations;
    }
}
