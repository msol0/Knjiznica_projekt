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
            dgKnjige.DataSource = _knjigaStore.SveKnjige();
            dgKnjige.Columns[3].Visible = false;
            dgKnjige.Columns[8].Visible = false;
            dgKnjige.Columns[9].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditBooksForm addEditForm = new AddEditBooksForm(new Knjiga());

            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                dgKnjige.DataSource = _knjigaStore.SveKnjige();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
