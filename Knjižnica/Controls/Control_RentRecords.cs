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
    public partial class Control_RentRecords : UserControl
    {
        private KnjigaStore _knjigaStore;
        public Control_RentRecords()
        {
            if (_knjigaStore == null)
                _knjigaStore = new KnjigaStore();
            InitializeComponent();
            dgRentRecords.DataSource = _knjigaStore.GetEvidencijaZaduzenja();
        }
    }
}
