using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TmpDividasEmpresa
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
        public short? Parcela { get; set; }
        public DateTime? Vencimento { get; set; }
        public decimal? ValorDivAtualizado { get; set; }
    }
}
