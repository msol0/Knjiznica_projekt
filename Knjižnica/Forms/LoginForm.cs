using Knjižnica.Abstract.Models;
using Knjižnica.DB.Stores;
using Knjižnica.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Knjižnica
{
    public partial class LoginForm : Form
    {
        public Korisnik Korisnik { get; private set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            KorisnikStore korisnikStore = new KorisnikStore();

            Korisnik = korisnikStore.AutorizacijaKorisnika(txtUsername.Text, txtPassword.Text,txtEmail.Text);

            if (Korisnik.Pravo == Abstract.Enums.PravaEnums.Korisnik) 
            {
                this.DialogResult = DialogResult.OK;
                
            }
            else if(Korisnik.Pravo == Abstract.Enums.PravaEnums.Administrator)
            {
                this.DialogResult = DialogResult.OK;
            }
            else { 
                MessageBox.Show("Neispravan unos podataka!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
