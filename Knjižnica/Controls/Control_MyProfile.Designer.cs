namespace Knjižnica.Controls
{
    partial class Control_MyProfile
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
            this.tcMyProfile = new System.Windows.Forms.TabControl();
            this.TabPageInfoChange = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TabPagePasswordChange = new System.Windows.Forms.TabPage();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassChange = new System.Windows.Forms.Label();
            this.tcMyProfile.SuspendLayout();
            this.TabPageInfoChange.SuspendLayout();
            this.TabPagePasswordChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMyProfile
            // 
            this.tcMyProfile.Controls.Add(this.TabPageInfoChange);
            this.tcMyProfile.Controls.Add(this.TabPagePasswordChange);
            this.tcMyProfile.Location = new System.Drawing.Point(0, 3);
            this.tcMyProfile.Name = "tcMyProfile";
            this.tcMyProfile.SelectedIndex = 0;
            this.tcMyProfile.Size = new System.Drawing.Size(758, 298);
            this.tcMyProfile.TabIndex = 20;
            // 
            // TabPageInfoChange
            // 
            this.TabPageInfoChange.BackColor = System.Drawing.Color.OldLace;
            this.TabPageInfoChange.Controls.Add(this.button1);
            this.TabPageInfoChange.Controls.Add(this.lblNaslov);
            this.TabPageInfoChange.Controls.Add(this.textBox4);
            this.TabPageInfoChange.Controls.Add(this.lblUsername);
            this.TabPageInfoChange.Controls.Add(this.textBox3);
            this.TabPageInfoChange.Controls.Add(this.lblName);
            this.TabPageInfoChange.Controls.Add(this.textBox2);
            this.TabPageInfoChange.Controls.Add(this.lblEmail);
            this.TabPageInfoChange.Controls.Add(this.lblSurname);
            this.TabPageInfoChange.Controls.Add(this.textBox1);
            this.TabPageInfoChange.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.TabPageInfoChange.Location = new System.Drawing.Point(4, 25);
            this.TabPageInfoChange.Name = "TabPageInfoChange";
            this.TabPageInfoChange.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInfoChange.Size = new System.Drawing.Size(750, 269);
            this.TabPageInfoChange.TabIndex = 0;
            this.TabPageInfoChange.Text = "Promjena podataka";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(299, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Spremi promjene";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Underline);
            this.lblNaslov.Location = new System.Drawing.Point(32, 40);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(141, 26);
            this.lblNaslov.TabIndex = 17;
            this.lblNaslov.Text = "Uredi svoj profil:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(543, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 23);
            this.textBox4.TabIndex = 25;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblUsername.Location = new System.Drawing.Point(33, 103);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 24);
            this.lblUsername.TabIndex = 18;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(543, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 23);
            this.textBox3.TabIndex = 24;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblName.Location = new System.Drawing.Point(33, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 24);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Ime:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 23);
            this.textBox2.TabIndex = 23;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblEmail.Location = new System.Drawing.Point(392, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 24);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblSurname.Location = new System.Drawing.Point(392, 103);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(75, 24);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Prezime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 23);
            this.textBox1.TabIndex = 22;
            // 
            // TabPagePasswordChange
            // 
            this.TabPagePasswordChange.BackColor = System.Drawing.Color.OldLace;
            this.TabPagePasswordChange.Controls.Add(this.btnSavePass);
            this.TabPagePasswordChange.Controls.Add(this.textBox7);
            this.TabPagePasswordChange.Controls.Add(this.textBox6);
            this.TabPagePasswordChange.Controls.Add(this.textBox5);
            this.TabPagePasswordChange.Controls.Add(this.label1);
            this.TabPagePasswordChange.Controls.Add(this.lblNewPass);
            this.TabPagePasswordChange.Controls.Add(this.label2);
            this.TabPagePasswordChange.Controls.Add(this.lblPassChange);
            this.TabPagePasswordChange.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.TabPagePasswordChange.Location = new System.Drawing.Point(4, 25);
            this.TabPagePasswordChange.Name = "TabPagePasswordChange";
            this.TabPagePasswordChange.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePasswordChange.Size = new System.Drawing.Size(750, 269);
            this.TabPagePasswordChange.TabIndex = 1;
            this.TabPagePasswordChange.Text = "Promjena lozinke";
            // 
            // btnSavePass
            // 
            this.btnSavePass.AutoSize = true;
            this.btnSavePass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSavePass.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnSavePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSavePass.Location = new System.Drawing.Point(547, 204);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(151, 36);
            this.btnSavePass.TabIndex = 7;
            this.btnSavePass.Text = "Spremi promjene";
            this.btnSavePass.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(267, 204);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(222, 30);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(267, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 30);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(267, 96);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 30);
            this.textBox5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ponovni unos nove lozinke:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNewPass.Location = new System.Drawing.Point(37, 159);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(108, 24);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Nova lozinka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trenutna lozinka:";
            // 
            // lblPassChange
            // 
            this.lblPassChange.AutoSize = true;
            this.lblPassChange.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Underline);
            this.lblPassChange.Location = new System.Drawing.Point(36, 39);
            this.lblPassChange.Name = "lblPassChange";
            this.lblPassChange.Size = new System.Drawing.Size(150, 26);
            this.lblPassChange.TabIndex = 0;
            this.lblPassChange.Text = "Promjena lozinke";
            // 
            // Control_MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.tcMyProfile);
            this.Name = "Control_MyProfile";
            this.Size = new System.Drawing.Size(754, 299);
            this.tcMyProfile.ResumeLayout(false);
            this.TabPageInfoChange.ResumeLayout(false);
            this.TabPageInfoChange.PerformLayout();
            this.TabPagePasswordChange.ResumeLayout(false);
            this.TabPagePasswordChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMyProfile;
        private System.Windows.Forms.TabPage TabPageInfoChange;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage TabPagePasswordChange;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassChange;
    }
}
