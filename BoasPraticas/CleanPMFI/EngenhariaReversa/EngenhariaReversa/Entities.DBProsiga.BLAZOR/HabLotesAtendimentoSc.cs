using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class HabLotesAtendimentoSc
    {
        public string InscricaoImobiliaria { get; set; } = null!;
        public int? Status { get; set; }
        public string? UsuId { get; set; }
        public DateTime DtCadastro { get; set; }
        public string? Observacao { get; set; }
        public decimal? ValorTerreno { get; set; }
        public string? ImobiliariaOrigem { get; set; }
    }
}
