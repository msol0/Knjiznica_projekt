namespace Knjižnica.Controls
{
    partial class Control_SearchRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_SearchRent));
            this.btnRent = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRent
            // 
            this.btnRent.AutoSize = true;
            this.btnRent.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRent.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(593, 316);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(87, 32);
            this.btnRent.TabIndex = 20;
            this.btnRent.Text = "Posudi";
            this.btnRent.UseVisualStyleBackColor = false;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPretraga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPretraga.Image = ((System.Drawing.Image)(resources.GetObject("btnPretraga.Image")));
            this.btnPretraga.Location = new System.Drawing.Point(647, 9);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(33, 28);
            this.btnPretraga.TabIndex = 19;
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 18;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Arial Narrow", 11.5F);
            this.lblAvailable.Location = new System.Drawing.Point(1, 12);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(186, 24);
            this.lblAvailable.TabIndex = 17;
            this.lblAvailable.Text = "Katalog dostupnih knjiga";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(675, 232);
            this.dataGridView1.TabIndex = 16;
            // 
            // Control_SearchRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Control_SearchRent";
            this.Size = new System.Drawing.Size(708, 366);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
