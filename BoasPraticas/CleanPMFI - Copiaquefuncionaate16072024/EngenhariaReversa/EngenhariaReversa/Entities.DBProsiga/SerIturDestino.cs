using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SerIturDestino
    {
        public SerIturDestino()
        {
            Atrativos = new HashSet<SerIturAtrativosTuristico>();
        }

        public long DestinoId { get; set; }
        public string? DestinoNome { get; set; }
        public decimal? DestinoKm { get; set; }
        public string? DestinoTempo { get; set; }

        public virtual ICollection<SerIturAtrativosTuristico> Atrativos { get; set; }
    }
}
