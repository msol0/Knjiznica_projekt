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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Knjižnica.Forms
{
    public partial class AddEditBooksForm : Form
    {
        private int Knjiga_ID = 0;
        private KnjigaStore _knjigaStore;
        public AddEditBooksForm(Knjiga knjiga)
        {
            if (_knjigaStore == null)
                _knjigaStore = new KnjigaStore();
            InitializeComponent();

            //povlačenje podataka iz baze za combo box
            cbJezik.DataSource = _knjigaStore.GetJezik();
            cbJezik.DisplayMember = "Jezik";
            cbJezik.ValueMember = "ID";

            cbKategorija.DataSource = _knjigaStore.GetKategorija();
            cbKategorija.DisplayMember = "Naziv";
            cbKategorija.ValueMember = "ID";

            cbGradja.DataSource = _knjigaStore.GetGradja();
            cbGradja.DisplayMember = "Naziv";
            cbGradja.ValueMember = "ID";

            //postavljanje toolova na odabrane vrijednosti iz dg
            if (knjiga != null & knjiga.ID != 0)
            {
                Knjiga_ID = knjiga.ID;
                txtNaslov.Text = knjiga.Naslov;
                txtAutor.Text = knjiga.Autor;
                txtMjestoIzdanja.Text = knjiga.Mjesto_izdavanja;
                txtIzdavac.Text = knjiga.Izdavac;
                cbJezik.Text = knjiga.Jezik;
                cbKategorija.Text = knjiga.Kategorija;
                cbGradja.Text = knjiga.Gradja;
                numKolicina.Value = knjiga.Kolicina;
                numDostupnost.Value = knjiga.Dostupnost ? 1 : 0; 
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = new Knjiga();

            knjiga.Naslov = txtNaslov.Text;
            knjiga.Autor = txtAutor.Text;
            knjiga.Mjesto_izdavanja = txtMjestoIzdanja.Text;
            knjiga.Izdavac = txtIzdavac.Text;
            knjiga.Jezik =(cbJezik.SelectedIndex+1).ToString();
            knjiga.Kategorija = (cbKategorija.SelectedIndex + 1).ToString();
            knjiga.Gradja = (cbGradja.SelectedIndex + 1).ToString();
            knjiga.Kolicina = (int)numKolicina.Value;
            knjiga.Dostupnost = numDostupnost.Value > 0;
            knjiga.ID = Knjiga_ID;

            if (Knjiga_ID != 0)
            {
                _knjigaStore.AzurirajGradju(knjiga);
            }
            else
            {
                _knjigaStore.DodajGradju(knjiga);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
