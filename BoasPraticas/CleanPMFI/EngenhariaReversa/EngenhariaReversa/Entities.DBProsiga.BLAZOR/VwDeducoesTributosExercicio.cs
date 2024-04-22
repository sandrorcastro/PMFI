using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwDeducoesTributosExercicio
    {
        public int? Exercicio { get; set; }
        public int TipoTribId { get; set; }
        public string? DsTributo { get; set; }
        public int Tipobxid { get; set; }
        public string? Tipobxnome { get; set; }
        public string? GrupoTipoBxNome { get; set; }
        public decimal? Total { get; set; }
    }
}
