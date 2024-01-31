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
    public partial class Control_Welcome : UserControl
    {
        public Control_Welcome(string ime, string prezime)
        {
            InitializeComponent();
            lblWelcome.Text = string.Format("Dobrodošao, {0} {1}!", ime, prezime);
        }
    }
}
