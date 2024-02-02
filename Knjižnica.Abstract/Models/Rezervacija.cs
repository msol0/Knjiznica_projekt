using Knjižnica.Abstract.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjižnica.Abstract.Models
{
    public class Rezervacija
    {
        public int ID { get; set; }
        public int ID_knjige { get; set; }
        public int ID_korisnika { get; set; }
        public string Korisnik {  get; set; }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public DateTime Datum_posudbe {  get; set; }
        public DateTime Datum_vracanja { get; set; }
        public string Status {  get; set; }
    }
}
