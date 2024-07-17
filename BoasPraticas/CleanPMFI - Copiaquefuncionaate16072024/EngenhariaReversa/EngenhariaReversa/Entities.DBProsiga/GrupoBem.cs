using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class GrupoBem
    {
        public GrupoBem()
        {
            Generos = new HashSet<Genero>();
        }

        /// <summary>
        /// Bens Permanentes ou Material de Consumo
        /// </summary>
        public int GrupoBemId { get; set; }
        public string? GrupoBemNome { get; set; }

        public virtual ICollection<Genero> Generos { get; set; }
    }
}
