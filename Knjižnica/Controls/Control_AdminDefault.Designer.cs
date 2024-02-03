namespace Knjižnica.Controls
{
    partial class Control_AdminDefault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_AdminDefault));
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAllUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRecords = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBooks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.Location = new System.Drawing.Point(176, 14);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(807, 498);
            this.panelAdmin.TabIndex = 7;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAllUsers,
            this.toolStripSeparator2,
            this.btnRecords,
            this.toolStripSeparator4,
            this.btnBooks,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(162, 536);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAllUsers.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.btnAllUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnAllUsers.Image")));
            this.btnAllUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(159, 27);
            this.btnAllUsers.Text = "Popis svih korisnika";
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // btnRecords
            // 
            this.btnRecords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRecords.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.btnRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnRecords.Image")));
            this.btnRecords.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(159, 27);
            this.btnRecords.Text = "Evidencija dugovanja";
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(159, 6);
            // 
            // btnBooks
            // 
            this.btnBooks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnBooks.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.btnBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnBooks.Image")));
            this.btnBooks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(159, 27);
            this.btnBooks.Text = "Uređivanje građe";
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(159, 6);
            // 
            // Control_AdminDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Control_AdminDefault";
            this.Size = new System.Drawing.Size(1009, 536);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAllUsers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnRecords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnBooks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
