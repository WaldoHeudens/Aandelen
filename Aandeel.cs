using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8_3
{
    internal class Aandeel
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string MijnOmschrijving { get; set; }

          Boolean isToegevoegd { get; set; }
        public Boolean isGewijzigd;
        public List<Transactie> Transacties { get; set; }

        public bool werdToegevoegd()
        {
            return isToegevoegd;
        }

        public void Toevoegen(bool toevoegen = true)
        {
            isToegevoegd = toevoegen;
        }
    }
}
