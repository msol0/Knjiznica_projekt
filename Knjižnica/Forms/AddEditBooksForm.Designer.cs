namespace Knjižnica.Forms
{
    partial class AddEditBooksForm
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtIzdavac = new System.Windows.Forms.TextBox();
            this.txtMjestoIzdanja = new System.Windows.Forms.TextBox();
            this.lblIzdavac = new System.Windows.Forms.Label();
            this.lblMjestoIzdanja = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.lblJezik = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lblGradja = new System.Windows.Forms.Label();
            this.lblDostupnost = new System.Windows.Forms.Label();
            this.cbJezik = new System.Windows.Forms.ComboBox();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.cbGradja = new System.Windows.Forms.ComboBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.numDostupnost = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDostupnost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.AutoSize = true;
            this.btnSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(226)))), ((int)(((byte)(151)))));
            this.btnSpremi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(226)))), ((int)(((byte)(151)))));
            this.btnSpremi.FlatAppearance.BorderSize = 0;
            this.btnSpremi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(80, 464);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(155, 37);
            this.btnSpremi.TabIndex = 42;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.AutoSize = true;
            this.btnOdustani.BackColor = System.Drawing.Color.Red;
            this.btnOdustani.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(226)))), ((int)(((byte)(151)))));
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(283, 464);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(155, 37);
            this.btnOdustani.TabIndex = 41;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtIzdavac
            // 
            this.txtIzdavac.Location = new System.Drawing.Point(217, 185);
            this.txtIzdavac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIzdavac.Name = "txtIzdavac";
            this.txtIzdavac.Size = new System.Drawing.Size(221, 22);
            this.txtIzdavac.TabIndex = 4;
            // 
            // txtMjestoIzdanja
            // 
            this.txtMjestoIzdanja.Location = new System.Drawing.Point(217, 135);
            this.txtMjestoIzdanja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMjestoIzdanja.Name = "txtMjestoIzdanja";
            this.txtMjestoIzdanja.Size = new System.Drawing.Size(221, 22);
            this.txtMjestoIzdanja.TabIndex = 3;
            // 
            // lblIzdavac
            // 
            this.lblIzdavac.AutoSize = true;
            this.lblIzdavac.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblIzdavac.Location = new System.Drawing.Point(53, 181);
            this.lblIzdavac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIzdavac.Name = "lblIzdavac";
            this.lblIzdavac.Size = new System.Drawing.Size(78, 26);
            this.lblIzdavac.TabIndex = 38;
            this.lblIzdavac.Text = "Izdavač:";
            // 
            // lblMjestoIzdanja
            // 
            this.lblMjestoIzdanja.AutoSize = true;
            this.lblMjestoIzdanja.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblMjestoIzdanja.Location = new System.Drawing.Point(53, 131);
            this.lblMjestoIzdanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMjestoIzdanja.Name = "lblMjestoIzdanja";
            this.lblMjestoIzdanja.Size = new System.Drawing.Size(151, 26);
            this.lblMjestoIzdanja.TabIndex = 37;
            this.lblMjestoIzdanja.Text = "Mjesto izdavanja:";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(217, 84);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(221, 22);
            this.txtAutor.TabIndex = 2;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblNaslov.Location = new System.Drawing.Point(53, 33);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(72, 26);
            this.lblNaslov.TabIndex = 35;
            this.lblNaslov.Text = "Naslov:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblAutor.Location = new System.Drawing.Point(53, 80);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(59, 26);
            this.lblAutor.TabIndex = 34;
            this.lblAutor.Text = "Autor:";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(217, 38);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(221, 22);
            this.txtNaslov.TabIndex = 1;
            // 
            // lblJezik
            // 
            this.lblJezik.AutoSize = true;
            this.lblJezik.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblJezik.Location = new System.Drawing.Point(53, 227);
            this.lblJezik.Name = "lblJezik";
            this.lblJezik.Size = new System.Drawing.Size(58, 26);
            this.lblJezik.TabIndex = 43;
            this.lblJezik.Text = "Jezik:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblKategorija.Location = new System.Drawing.Point(53, 277);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(98, 26);
            this.lblKategorija.TabIndex = 44;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblKolicina.Location = new System.Drawing.Point(53, 360);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(80, 26);
            this.lblKolicina.TabIndex = 45;
            this.lblKolicina.Text = "Količina:";
            // 
            // lblGradja
            // 
            this.lblGradja.AutoSize = true;
            this.lblGradja.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblGradja.Location = new System.Drawing.Point(53, 318);
            this.lblGradja.Name = "lblGradja";
            this.lblGradja.Size = new System.Drawing.Size(111, 26);
            this.lblGradja.TabIndex = 46;
            this.lblGradja.Text = "Vrsta građe:";
            // 
            // lblDostupnost
            // 
            this.lblDostupnost.AutoSize = true;
            this.lblDostupnost.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lblDostupnost.Location = new System.Drawing.Point(53, 403);
            this.lblDostupnost.Name = "lblDostupnost";
            this.lblDostupnost.Size = new System.Drawing.Size(108, 26);
            this.lblDostupnost.TabIndex = 47;
            this.lblDostupnost.Text = "Dostupnost:";
            // 
            // cbJezik
            // 
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Location = new System.Drawing.Point(217, 228);
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.Size = new System.Drawing.Size(221, 24);
            this.cbJezik.TabIndex = 5;
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(217, 277);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(221, 24);
            this.cbKategorija.TabIndex = 6;
            // 
            // cbGradja
            // 
            this.cbGradja.FormattingEnabled = true;
            this.cbGradja.Location = new System.Drawing.Point(217, 318);
            this.cbGradja.Name = "cbGradja";
            this.cbGradja.Size = new System.Drawing.Size(221, 24);
            this.cbGradja.TabIndex = 7;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(217, 364);
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(52, 22);
            this.numKolicina.TabIndex = 48;
            // 
            // numDostupnost
            // 
            this.numDostupnost.Location = new System.Drawing.Point(217, 409);
            this.numDostupnost.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDostupnost.Name = "numDostupnost";
            this.numDostupnost.Size = new System.Drawing.Size(52, 22);
            this.numDostupnost.TabIndex = 49;
            // 
            // AddEditBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(541, 522);
            this.Controls.Add(this.numDostupnost);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.cbGradja);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.cbJezik);
            this.Controls.Add(this.lblDostupnost);
            this.Controls.Add(this.lblGradja);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.lblJezik);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtIzdavac);
            this.Controls.Add(this.txtMjestoIzdanja);
            this.Controls.Add(this.lblIzdavac);
            this.Controls.Add(this.lblMjestoIzdanja);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtNaslov);
            this.Name = "AddEditBooksForm";
            this.Text = "AddEditBooksForm";
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDostupnost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtIzdavac;
        private System.Windows.Forms.TextBox txtMjestoIzdanja;
        private System.Windows.Forms.Label lblIzdavac;
        private System.Windows.Forms.Label lblMjestoIzdanja;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblJezik;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.Label lblGradja;
        private System.Windows.Forms.Label lblDostupnost;
        private System.Windows.Forms.ComboBox cbJezik;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.ComboBox cbGradja;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.NumericUpDown numDostupnost;
    }
}