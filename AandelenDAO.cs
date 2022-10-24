using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_8_3
{
    internal class AandelenDAO
    {
        public List<Aandeel> Aandelen { get; set; }


        public List<Aandeel> getAlleAandelen ()
        {
            List<Aandeel> aandelen = new List<Aandeel>();

            // Even een paar dummy aandelen
            aandelen.Add(new Aandeel() { Id = 1, MijnOmschrijving = "nonsens", Naam = "XX1" });
            aandelen.Add(new Aandeel() { Id = 2, MijnOmschrijving = "omschrijving 2", Naam = "XX2" });
            aandelen.Add(new Aandeel() { Id = 3, MijnOmschrijving = "omschrijving 3", Naam = "XX3" });

            return aandelen;
        }
    }
}
