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
    public partial class Control_MyReservations : UserControl
    {
        private KnjigaStore _knjigaStore;
        private int id_korisnika;
        private int id_knjige;
        public Control_MyReservations(int id_korisnika)
        {
            if (_knjigaStore == null)
                _knjigaStore = new KnjigaStore();

            InitializeComponent();

            this.id_korisnika = id_korisnika;

            dgReservations.DataSource = _knjigaStore.GetRezervacija(id_korisnika);
            dgReservations.Columns[2].Visible = false;
            dgReservations.Columns[3].Visible = false;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgReservations.SelectedRows.Count > 0)
            {
                id_knjige = Convert.ToInt32(dgReservations.SelectedRows[0].Cells["ID_knjige"].Value);
                _knjigaStore.VratiKnjigu(id_knjige, id_korisnika);
                dgReservations.DataSource = _knjigaStore.GetRezervacija(id_korisnika);
            }
        }
    }
}
