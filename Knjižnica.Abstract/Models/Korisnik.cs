using Knjižnica.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjižnica.Abstract.Models
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime Datum_clanarine { get; set; }
        public bool Aktivan { get; set; }
        public PravaEnums Pravo { get; set; }
    }
}
