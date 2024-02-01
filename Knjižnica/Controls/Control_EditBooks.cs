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

namespace Knjižnica.Controls
{
    public partial class Control_EditBooks : UserControl
    {
        private KnjigaStore _knjigaStore;
        public Control_EditBooks()
        {
            if(_knjigaStore == null)
            {
                _knjigaStore = new KnjigaStore();
            }
            InitializeComponent();
            dgKnjige.DataSource = _knjigaStore.GetSveKnjige();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditBooksForm addEditForm = new AddEditBooksForm(new Knjiga());

            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                dgKnjige.DataSource = _knjigaStore.GetSveKnjige();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = new Knjiga();

            knjiga.ID = Convert.ToInt32(dgKnjige.SelectedRows[0].Cells["ID"].Value);
            knjiga.Naslov = dgKnjige.SelectedRows[0].Cells["Naslov"].Value.ToString();
            knjiga.Autor = dgKnjige.SelectedRows[0].Cells["Autor"].Value.ToString();
            knjiga.Mjesto_izdavanja = dgKnjige.SelectedRows[0].Cells["Mjesto_izdavanja"].Value.ToString();
            knjiga.Izdavac = dgKnjige.SelectedRows[0].Cells["Izdavac"].Value.ToString();
            knjiga.Jezik = dgKnjige.SelectedRows[0].Cells["Jezik"].Value.ToString();
            knjiga.Gradja = dgKnjige.SelectedRows[0].Cells["Gradja"].Value.ToString();
            knjiga.Kategorija = dgKnjige.SelectedRows[0].Cells["Kategorija"].Value.ToString();
            knjiga.Kolicina = (int) dgKnjige.SelectedRows[0].Cells["Kolicina"].Value;
            knjiga.Dostupnost = (bool) dgKnjige.SelectedRows[0].Cells["Dostupnost"].Value;

            AddEditBooksForm addEditForm = new AddEditBooksForm(knjiga);

            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                dgKnjige.DataSource = _knjigaStore.GetSveKnjige();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite obrisati ovu građu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                int selectedId = Convert.ToInt32(dgKnjige.SelectedRows[0].Cells["ID"].Value);

                _knjigaStore.ObrisiGradju(selectedId);

                dgKnjige.DataSource = _knjigaStore.GetSveKnjige();
            }
        }
    }
}
