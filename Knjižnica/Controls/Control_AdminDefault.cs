using Knjižnica.Abstract.Models;
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
    public partial class Control_AdminDefault : UserControl
    {
        private Korisnik _korisnik;
        public Control_AdminDefault(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void tsBtnProfil_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(new Control_MyProfile(_korisnik));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(new Control_ShowAllUsers());
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(new Control_RentRecords());
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(new Control_EditBooks());
        }
    }
}
