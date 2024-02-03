namespace Knjižnica.Controls
{
    partial class Control_Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Catalog));
            this.btnRent = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtTrazi = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.dgDostupneKnjige = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDostupneKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.AutoSize = true;
            this.btnRent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRent.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(771, 438);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(115, 32);
            this.btnRent.TabIndex = 20;
            this.btnRent.Text = "Posudi knjigu";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPretraga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPretraga.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraga.Image")));
            this.btnPretraga.Location = new System.Drawing.Point(895, 12);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(40, 39);
            this.btnPretraga.TabIndex = 19;
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // txtTrazi
            // 
            this.txtTrazi.Font = new System.Drawing.Font("Arial", 13F);
            this.txtTrazi.Location = new System.Drawing.Point(645, 16);
            this.txtTrazi.Name = "txtTrazi";
            this.txtTrazi.Size = new System.Drawing.Size(220, 32);
            this.txtTrazi.TabIndex = 18;
            this.txtTrazi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrazi_KeyDown);
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Arial Narrow", 15F);
            this.lblAvailable.Location = new System.Drawing.Point(25, 12);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(231, 30);
            this.lblAvailable.TabIndex = 17;
            this.lblAvailable.Text = "Katalog dostupnih knjiga";
            // 
            // dgDostupneKnjige
            // 
            this.dgDostupneKnjige.AllowUserToAddRows = false;
            this.dgDostupneKnjige.AllowUserToDeleteRows = false;
            this.dgDostupneKnjige.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDostupneKnjige.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDostupneKnjige.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgDostupneKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDostupneKnjige.GridColor = System.Drawing.Color.OldLace;
            this.dgDostupneKnjige.Location = new System.Drawing.Point(30, 62);
            this.dgDostupneKnjige.Name = "dgDostupneKnjige";
            this.dgDostupneKnjige.RowHeadersWidth = 51;
            this.dgDostupneKnjige.RowTemplate.Height = 24;
            this.dgDostupneKnjige.Size = new System.Drawing.Size(905, 352);
            this.dgDostupneKnjige.TabIndex = 16;
            // 
            // Control_Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtTrazi);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.dgDostupneKnjige);
            this.Name = "Control_Catalog";
            this.Size = new System.Drawing.Size(1009, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dgDostupneKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtTrazi;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.DataGridView dgDostupneKnjige;
    }
}
