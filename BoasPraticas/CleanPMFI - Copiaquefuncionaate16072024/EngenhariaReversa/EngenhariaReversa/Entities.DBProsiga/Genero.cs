using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Genero
    {
        public Genero()
        {
            Especies = new HashSet<Especie>();
        }

        public int GeneroId { get; set; }
        public string? NmGenero { get; set; }
        public int? GrupoBemId { get; set; }

        public virtual GrupoBem? GrupoBem { get; set; }
        public virtual ICollection<Especie> Especies { get; set; }
    }
}
