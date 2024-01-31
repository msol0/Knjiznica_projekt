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
            

            if (knjiga != null & knjiga.ID != 0)
            {
                //Ažuriranje
                this.Text = "Ažuriraj podatak";
                btnSpremi.Text = "Ažuriraj";

                txtNaslov.Text = knjiga.Naslov;
                txtAutor.Text = knjiga.Autor;
                txtTelefon.Text = kontakt.Broj_telefona;
                txtAdresa.Text = kontakt.Adresa;
                Knjiga_ID = knjiga.ID;
            }
        }
    }
}
