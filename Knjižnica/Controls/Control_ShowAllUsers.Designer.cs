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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowUsers
            // 
            this.lblShowUsers.AutoSize = true;
            this.lblShowUsers.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Underline);
            this.lblShowUsers.Location = new System.Drawing.Point(31, 0);
            this.lblShowUsers.Name = "lblShowUsers";
            this.lblShowUsers.Size = new System.Drawing.Size(170, 26);
            this.lblShowUsers.TabIndex = 0;
            this.lblShowUsers.Text = "Popis svih korisnika";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 298);
            this.dataGridView1.TabIndex = 1;
            // 
            // Control_ShowAllUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblShowUsers);
            this.Name = "Control_ShowAllUsers";
            this.Size = new System.Drawing.Size(626, 413);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
