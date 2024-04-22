using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribSimplesNacionalEvento
    {
        public TribSimplesNacionalEvento()
        {
            TribSimplesNacionalOcorrEventos = new HashSet<TribSimplesNacionalOcorrEvento>();
        }

        public short SneventoId { get; set; }
        public string SneventoNome { get; set; } = null!;
        public string? SneventoEnquadra { get; set; }
        public int? IdRegra { get; set; }

        public virtual ICollection<TribSimplesNacionalOcorrEvento> TribSimplesNacionalOcorrEventos { get; set; }
    }
}
