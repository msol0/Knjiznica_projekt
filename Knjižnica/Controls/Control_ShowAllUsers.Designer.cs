namespace Knjižnica.Controls
{
    partial class Control_ShowAllUsers
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
            this.lblShowUsers = new System.Windows.Forms.Label();
            this.dgKorisnici = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowUsers
            // 
            this.lblShowUsers.AutoSize = true;
            this.lblShowUsers.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Underline);
            this.lblShowUsers.Location = new System.Drawing.Point(35, 19);
            this.lblShowUsers.Name = "lblShowUsers";
            this.lblShowUsers.Size = new System.Drawing.Size(170, 26);
            this.lblShowUsers.TabIndex = 0;
            this.lblShowUsers.Text = "Popis svih korisnika";
            // 
            // dgKorisnici
            // 
            this.dgKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgKorisnici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKorisnici.Location = new System.Drawing.Point(40, 68);
            this.dgKorisnici.Name = "dgKorisnici";
            this.dgKorisnici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgKorisnici.RowTemplate.Height = 24;
            this.dgKorisnici.Size = new System.Drawing.Size(712, 380);
            this.dgKorisnici.TabIndex = 1;
            // 
            // Control_ShowAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.dgKorisnici);
            this.Controls.Add(this.lblShowUsers);
            this.Name = "Control_ShowAllUsers";
            this.Size = new System.Drawing.Size(792, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dgKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowUsers;
        private System.Windows.Forms.DataGridView dgKorisnici;
    }
}
