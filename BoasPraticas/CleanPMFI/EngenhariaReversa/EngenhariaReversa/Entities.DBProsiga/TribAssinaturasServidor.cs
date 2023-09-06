using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAssinaturasServidor
    {
        public int ServId { get; set; }
        public int IdDocumento { get; set; }
        public string? NmCargo { get; set; }
        public int? NrSequencia { get; set; }
        public DateTime? DtInicial { get; set; }
        public DateTime? DtFim { get; set; }
    }
}
