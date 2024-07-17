using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeFarmaSaldoInicial
    {
        public long IdConfiguraEstoque { get; set; }
        public int? IdEstoque { get; set; }
        public int? IdFabricante { get; set; }
        public string? IdentLote { get; set; }
        public int? IdMedicamento { get; set; }
        public DateTime? DtFabricacao { get; set; }
        public DateTime? DtValidade { get; set; }
        public long? Quant { get; set; }
        public string? Usuario { get; set; }
        public DateTime? DataLcto { get; set; }
        public string? NomeComercial { get; set; }
        public long? Custo { get; set; }

        public virtual SaudeLote? Id { get; set; }
        public virtual SaudeEstoque? IdEstoqueNavigation { get; set; }
    }
}
