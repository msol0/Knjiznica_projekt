namespace Knjižnica.Forms
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLogOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnProfil = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBooks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.btnRecords = new System.Windows.Forms.ToolStripButton();
            this.btnAllUsers = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOut,
            this.toolStripSeparator1,
            this.tsBtnProfil});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(945, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLogOut.BackColor = System.Drawing.Color.SeaShell;
            this.btnLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(73, 34);
            this.btnLogOut.Text = "Odjava";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsBtnProfil
            // 
            this.tsBtnProfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnProfil.BackColor = System.Drawing.Color.SeaShell;
            this.tsBtnProfil.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.tsBtnProfil.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProfil.Image")));
            this.tsBtnProfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnProfil.Name = "tsBtnProfil";
            this.tsBtnProfil.Size = new System.Drawing.Size(104, 34);
            this.tsBtnProfil.Text = "Moj profil";
            this.tsBtnProfil.Click += new System.EventHandler(this.tsBtnProfil_Click);
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 37);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(162, 492);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
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
            // panelAdmin
            // 
            this.panelAdmin.Location = new System.Drawing.Point(165, 40);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(780, 489);
            this.panelAdmin.TabIndex = 4;
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
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(945, 529);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenuForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLogOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnProfil;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnBooks;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAllUsers;
        private System.Windows.Forms.ToolStripButton btnRecords;
    }
}