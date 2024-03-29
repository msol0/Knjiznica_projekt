﻿using Knjižnica.DB.Stores;
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
    public partial class Control_ShowAllUsers : UserControl
    {
        private KorisnikStore _korisnikStore;
        public Control_ShowAllUsers()
        {
            InitializeComponent();

            if (_korisnikStore == null)
                _korisnikStore = new KorisnikStore();

            var korisnici = _korisnikStore.GetKorisnik();
            dgKorisnici.DataSource = korisnici;
        }
    }
}
