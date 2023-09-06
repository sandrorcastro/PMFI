using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwCelioSimple
    {
        public int? EmprCmc { get; set; }
        public int? ConId { get; set; }
        public string? ConCnpjcpf { get; set; }
        public string? ConNome { get; set; }
        public string? Tipo { get; set; }
        public int? TipoTribId { get; set; }
        public string? TipoTribNome { get; set; }
        public short? AnoDiv { get; set; }
        public short? MesDiv { get; set; }
        public int? Parcelas { get; set; }
        public decimal? ValorTotalCorr { get; set; }
    }
}
