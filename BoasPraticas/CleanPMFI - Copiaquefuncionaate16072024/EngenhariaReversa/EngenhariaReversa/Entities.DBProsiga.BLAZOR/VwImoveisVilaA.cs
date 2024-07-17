using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwImoveisVilaA
    {
        public string InscricaoImobiliaria { get; set; } = null!;
        public string? EdifMatricula { get; set; }
        public string? LogradTipo { get; set; }
        public string? LogradNome { get; set; }
        public string? Descricao { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
        public decimal? AreaTerreno { get; set; }
        public decimal? AreaConstruida { get; set; }
        public string? Proprietario { get; set; }
        public string? Utilizacao { get; set; }
        public decimal? ValorIptu { get; set; }
        public decimal? ValorBaixadoIptu { get; set; }
    }
}
