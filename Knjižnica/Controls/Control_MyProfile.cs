using Knjižnica.Abstract.Models;
using Knjižnica.DB.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjižnica.Controls
{
    public partial class Control_MyProfile : UserControl
    {

        private int Korisnik_ID = 0;
        private Korisnik _korisnik;
        private KorisnikStore _korisnikStore;

        public Control_MyProfile(Korisnik korisnik)
        {
            InitializeComponent();

            if (_korisnikStore == null)
                _korisnikStore = new KorisnikStore();

            _korisnik = korisnik;

            txtUsername.Text = _korisnik.Korisnicko_ime;
            txtName.Text = _korisnik.Ime;
            txtSurname.Text = _korisnik.Prezime;
            txtEmail.Text = _korisnik.Email;
            Korisnik_ID = _korisnik.ID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PromjenaPodataka();
        }


        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                PromjenaPodataka();
            }
        }

        private void PromjenaPodataka()
        {
            _korisnik.Korisnicko_ime = txtUsername.Text;
            _korisnik.Ime = txtName.Text;
            _korisnik.Prezime = txtSurname.Text;
            _korisnik.Email = txtEmail.Text;

            _korisnikStore.AzurirajPodatke(_korisnik);
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            //_korisnikStore.ProvjeraLozinke(txtOldPass.Text, Korisnik_ID);
            AzuriranjeLozinke();

        }


        private void txtRepeatPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AzuriranjeLozinke();
            }
        }


        public void AzuriranjeLozinke()
        {
            bool provjera = _korisnikStore.ProvjeraLozinke(txtOldPass.Text, Korisnik_ID);
            if (provjera)
            {
                if (txtNewPass.Text == txtRepeatPass.Text)
                {
                    _korisnikStore.PromjenaLozinke(txtNewPass.Text, Korisnik_ID);
                }
                else { MessageBox.Show("Neispravan unos!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else { MessageBox.Show("Neispravan unos!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

    }
}
