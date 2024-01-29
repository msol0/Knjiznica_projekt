namespace Knjižnica.Forms
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSignOut = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnProfil = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.itemPosudi = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRezervacije = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdmin = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.panelGlavni = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblWelcome.Location = new System.Drawing.Point(37, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(119, 24);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Dobrodošao!";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSignOut,
            this.sep2,
            this.tsbtnProfil,
            this.tsbtnMenu,
            this.toolStripSeparator2,
            this.btnAdmin,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSignOut
            // 
            this.tsbtnSignOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnSignOut.BackColor = System.Drawing.Color.SeaShell;
            this.tsbtnSignOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tsbtnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tsbtnSignOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSignOut.Name = "tsbtnSignOut";
            this.tsbtnSignOut.Size = new System.Drawing.Size(73, 28);
            this.tsbtnSignOut.Text = "Odjava";
            this.tsbtnSignOut.Click += new System.EventHandler(this.tsbtnSignOut_Click);
            // 
            // sep2
            // 
            this.sep2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sep2.BackColor = System.Drawing.Color.Honeydew;
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnProfil
            // 
            this.tsbtnProfil.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnProfil.BackColor = System.Drawing.Color.SeaShell;
            this.tsbtnProfil.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.tsbtnProfil.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnProfil.Image")));
            this.tsbtnProfil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnProfil.Name = "tsbtnProfil";
            this.tsbtnProfil.Size = new System.Drawing.Size(104, 28);
            this.tsbtnProfil.Text = "Moj profil";
            this.tsbtnProfil.Click += new System.EventHandler(this.tsbtnProfil_Click);
            // 
            // tsbtnMenu
            // 
            this.tsbtnMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.tsbtnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPosudi,
            this.itemRezervacije});
            this.tsbtnMenu.Font = new System.Drawing.Font("Arial Narrow", 11F);
            this.tsbtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMenu.Image")));
            this.tsbtnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMenu.Name = "tsbtnMenu";
            this.tsbtnMenu.Size = new System.Drawing.Size(73, 28);
            this.tsbtnMenu.Text = "Usluge";
            // 
            // itemPosudi
            // 
            this.itemPosudi.Name = "itemPosudi";
            this.itemPosudi.Size = new System.Drawing.Size(249, 28);
            this.itemPosudi.Text = "Pretraži i posudi knjigu";
            this.itemPosudi.Click += new System.EventHandler(this.itemPosudi_Click);
            // 
            // itemRezervacije
            // 
            this.itemRezervacije.Name = "itemRezervacije";
            this.itemRezervacije.Size = new System.Drawing.Size(224, 28);
            this.itemRezervacije.Text = "Moje rezervacije";
            this.itemRezervacije.Click += new System.EventHandler(this.itemRezervacije_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdmin.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.Teal;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(58, 28);
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // panelGlavni
            // 
            this.panelGlavni.Location = new System.Drawing.Point(41, 97);
            this.panelGlavni.Name = "panelGlavni";
            this.panelGlavni.Size = new System.Drawing.Size(718, 349);
            this.panelGlavni.TabIndex = 7;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.panelGlavni);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnSignOut;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripButton tsbtnProfil;
        private System.Windows.Forms.ToolStripDropDownButton tsbtnMenu;
        private System.Windows.Forms.ToolStripMenuItem itemPosudi;
        private System.Windows.Forms.ToolStripMenuItem itemRezervacije;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAdmin;
        private System.Windows.Forms.Panel panelGlavni;
    }
}