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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.TabPagePasswordChange = new System.Windows.Forms.TabPage();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.lblOldPass = new System.Windows.Forms.Label();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
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
            this.TabPageInfoChange.Controls.Add(this.btnSave);
            this.TabPageInfoChange.Controls.Add(this.lblNaslov);
            this.TabPageInfoChange.Controls.Add(this.txtEmail);
            this.TabPageInfoChange.Controls.Add(this.lblUsername);
            this.TabPageInfoChange.Controls.Add(this.txtSurname);
            this.TabPageInfoChange.Controls.Add(this.lblName);
            this.TabPageInfoChange.Controls.Add(this.txtName);
            this.TabPageInfoChange.Controls.Add(this.lblEmail);
            this.TabPageInfoChange.Controls.Add(this.lblSurname);
            this.TabPageInfoChange.Controls.Add(this.txtUsername);
            this.TabPageInfoChange.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.TabPageInfoChange.Location = new System.Drawing.Point(4, 25);
            this.TabPageInfoChange.Name = "TabPageInfoChange";
            this.TabPageInfoChange.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageInfoChange.Size = new System.Drawing.Size(750, 269);
            this.TabPageInfoChange.TabIndex = 0;
            this.TabPageInfoChange.Text = "Promjena podataka";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(313, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 39);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Spremi promjene";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Underline);
            this.lblNaslov.Location = new System.Drawing.Point(32, 40);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(136, 26);
            this.lblNaslov.TabIndex = 17;
            this.lblNaslov.Text = "Uredi svoj profil";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(543, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
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
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(543, 103);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(169, 23);
            this.txtSurname.TabIndex = 3;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(184, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblEmail.Location = new System.Drawing.Point(452, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 24);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblSurname.Location = new System.Drawing.Point(452, 103);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(75, 24);
            this.lblSurname.TabIndex = 20;
            this.lblSurname.Text = "Prezime:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(184, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(169, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // TabPagePasswordChange
            // 
            this.TabPagePasswordChange.BackColor = System.Drawing.Color.OldLace;
            this.TabPagePasswordChange.Controls.Add(this.txtOldPass);
            this.TabPagePasswordChange.Controls.Add(this.lblOldPass);
            this.TabPagePasswordChange.Controls.Add(this.btnSavePass);
            this.TabPagePasswordChange.Controls.Add(this.txtRepeatPass);
            this.TabPagePasswordChange.Controls.Add(this.txtNewPass);
            this.TabPagePasswordChange.Controls.Add(this.label1);
            this.TabPagePasswordChange.Controls.Add(this.lblNewPass);
            this.TabPagePasswordChange.Controls.Add(this.lblPassChange);
            this.TabPagePasswordChange.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.TabPagePasswordChange.Location = new System.Drawing.Point(4, 25);
            this.TabPagePasswordChange.Name = "TabPagePasswordChange";
            this.TabPagePasswordChange.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePasswordChange.Size = new System.Drawing.Size(750, 269);
            this.TabPagePasswordChange.TabIndex = 1;
            this.TabPagePasswordChange.Text = "Promjena lozinke";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(267, 86);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(222, 30);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // lblOldPass
            // 
            this.lblOldPass.AutoSize = true;
            this.lblOldPass.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblOldPass.Location = new System.Drawing.Point(37, 92);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(108, 24);
            this.lblOldPass.TabIndex = 8;
            this.lblOldPass.Text = "Stara lozinka:";
            // 
            // btnSavePass
            // 
            this.btnSavePass.AutoSize = true;
            this.btnSavePass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSavePass.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold);
            this.btnSavePass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSavePass.Location = new System.Drawing.Point(530, 190);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(151, 36);
            this.btnSavePass.TabIndex = 4;
            this.btnSavePass.Text = "Spremi promjene";
            this.btnSavePass.UseVisualStyleBackColor = false;
            this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(267, 190);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(222, 30);
            this.txtRepeatPass.TabIndex = 3;
            this.txtRepeatPass.UseSystemPasswordChar = true;
            this.txtRepeatPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRepeatPass_KeyDown);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(267, 136);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(222, 30);
            this.txtNewPass.TabIndex = 2;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ponovni unos nove lozinke:";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.lblNewPass.Location = new System.Drawing.Point(37, 142);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(108, 24);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Nova lozinka:";
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TabPage TabPagePasswordChange;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblPassChange;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label lblOldPass;
    }
}
