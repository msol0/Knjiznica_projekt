using Knjižnica.Abstract.Models;
using Knjižnica.Controls;
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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm(Korisnik korisnik)
        {
            InitializeComponent();

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

        private void tsBtnProfil_Click(object sender, EventArgs e)
        {
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(new Control_MyProfile());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
