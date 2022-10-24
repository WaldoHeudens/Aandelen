using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8_3
{
    internal class Transactie
    {
        public int Id { get; set; }
        public int AandeelId { get; set; }
        public int AantalVerkocht { get; set; }
        public int AantalGekocht { get; set; }
        public double Prijs { get; set; }
        public DateTime Datum { get; set; }
    }
}
