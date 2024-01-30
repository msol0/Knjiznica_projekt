using Knjižnica.Abstract.Models;
using Knjižnica.Controls;
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

namespace Knjižnica.Forms
{
    public partial class MainMenuForm : Form
    {
        private Korisnik _korisnik;
        private KorisnikStore _korisnikStore;
        public MainMenuForm(Korisnik korisnik)
        {
            
            InitializeComponent();
            _korisnik = korisnik;
            lblWelcome.Text= string.Format("Dobrodošao, {0} {1}!", korisnik.Ime, korisnik.Prezime);
        }
        public void SakrijGumb()
        {
            btnAdmin.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminMenuForm adminMenuForm = new AdminMenuForm(_korisnik);
            adminMenuForm.ShowDialog();
        }

        private void tsbtnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnProfil_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_MyProfile());
        }


        private void itemRezervacije_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_MyReservations());
        }

        private void itemPosudi_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_SearchRent(_korisnik.Korisnicko_ime, _korisnik.ID));
        }

        
    }
}
