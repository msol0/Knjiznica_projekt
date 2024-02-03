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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Knjižnica.Forms
{
    public partial class MainMenuForm : Form
    {
        private Korisnik _korisnik;
        public MainMenuForm(Korisnik korisnik)
        {
            
            InitializeComponent();
            _korisnik = korisnik;
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_Welcome(_korisnik.Ime, _korisnik.Prezime));
        }
        public void SakrijGumb()
        {
            btnAdmin.Visible = false;
        }
        public void SakrijUsluge()
        {
            tsbtnMenu.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_AdminDefault(_korisnik));
        }

        private void tsbtnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnProfil_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_MyProfile(_korisnik));
        }


        private void itemRezervacije_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_MyReservations(_korisnik.ID));
        }

        private void itemPosudi_Click(object sender, EventArgs e)
        {
            panelGlavni.Controls.Clear();
            panelGlavni.Controls.Add(new Control_Catalog(_korisnik.Korisnicko_ime, _korisnik.ID));
        }
    }
}
