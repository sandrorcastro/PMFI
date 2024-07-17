using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribMovAnaliseAlvaraConstrucao
    {
        public long IdmovAnalise { get; set; }
        public DateTime? DataMov { get; set; }
        public long? Numero { get; set; }
        public string? StatusAprovacao { get; set; }
        public string? Historico { get; set; }
        public string? UsuId { get; set; }
    }
}
