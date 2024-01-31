using Knjižnica.DB;
using Knjižnica.DB.Stores;
using MySqlConnector;
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
    public partial class Control_SearchRent : UserControl
    {
        private KnjigaStore _knjigastore;
        public string username { get; set; }
        public int id { get; set; }
        public Control_SearchRent(string username, int id)
        {
            if (_knjigastore == null)
                _knjigastore = new KnjigaStore();

            InitializeComponent();
            this.username = username;
            this.id = id;
            Init();
        }
        private void Init()
        {
            dgDostupneKnjige.DataSource = _knjigastore.DostupneKnjige(id);
            dgDostupneKnjige.Columns[3].Visible = false;
            dgDostupneKnjige.Columns[8].Visible = false;
            dgDostupneKnjige.Columns[9].Visible = false;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

            if (dgDostupneKnjige.SelectedRows.Count > 0)
            {
                SqlConnectionFactory connectionManager = new SqlConnectionFactory();

                DataGridViewRow selectedRow = dgDostupneKnjige.SelectedRows[0];
                int id_knjiga = Convert.ToInt32(selectedRow.Cells["id"].Value);


                using (var connection = connectionManager.GetNewConnection())
                {
                    if (connection != null)
                    {
                        string prvi_upit = String.Format("UPDATE knjiga " +
                            "SET količina = količina - 1 " +
                            "WHERE id = @id_knjiga;");
                        using (var command = new MySqlCommand(prvi_upit, connection))
                        {
                            command.Parameters.AddWithValue("@id_knjiga", id_knjiga);
                            command.ExecuteNonQuery();
                        }

                        string drugi_upit = String.Format("UPDATE knjiga " +
                            "SET dostupnost = CASE " +
                            "WHEN količina = 0 THEN 0 " +
                            "ELSE dostupnost " +
                            "END " +
                            "WHERE id = @id_knjiga;");

                        using (var command = new MySqlCommand(drugi_upit, connection))
                        {
                            command.Parameters.AddWithValue("@id_knjiga", id_knjiga);
                            command.ExecuteNonQuery();
                        }
                    }
                    connectionManager.CloseConnection(connection);
                }
                _knjigastore.PosudiKnjigu(id, id_knjiga);
                dgDostupneKnjige.DataSource = _knjigastore.DostupneKnjige(id);
            }
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            var knjige = _knjigastore.DostupneKnjige(id);

            knjige = knjige.Where(x => x.Naslov.ToUpper().Contains(txtTrazi.Text.ToUpper())
                || x.Autor.ToUpper().Contains(txtTrazi.Text.ToUpper())
                || x.Jezik.ToUpper().Contains(txtTrazi.Text.ToUpper())
                || x.Izdavac.ToUpper().Contains(txtTrazi.Text.ToUpper())
                || x.Kategorija.ToUpper().Contains(txtTrazi.Text.ToUpper())).ToList();

            dgDostupneKnjige.DataSource = knjige;
        }

        private void txtTrazi_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Pretraga();
            }
        }
    }
}
