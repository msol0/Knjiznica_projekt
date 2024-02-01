using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjižnica.Abstract.Models
{
    public class Knjiga
    {
        public int ID { get; set; }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public string Mjesto_izdavanja { get; set; }
        public string Izdavac { get; set; }
        public string Jezik { get; set; }
        public string Gradja { get; set; }
        public string Kategorija { get; set; }
        public int Kolicina { get; set; }
        public bool Dostupnost {  get; set; }
    }
}
