using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Aaplan2009
    {
        public string? InscricoesImobiliarias { get; set; }
        public string? ProprietarioResponsavel { get; set; }
        public decimal? ValorVenal { get; set; }
        public decimal? ImpostoPredial { get; set; }
        public decimal? ImpostoTerritorial { get; set; }
        public string? EmissaoGuias { get; set; }
        public decimal? LimpezaPublica { get; set; }
        public decimal? ServicoBombeiros { get; set; }
        public decimal? ColetaLixo { get; set; }
        public decimal? IluminacaoPublica { get; set; }
        public decimal? Bonificacao { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalAtual { get; set; }
        public double? F15 { get; set; }
        public double? F16 { get; set; }
    }
}
