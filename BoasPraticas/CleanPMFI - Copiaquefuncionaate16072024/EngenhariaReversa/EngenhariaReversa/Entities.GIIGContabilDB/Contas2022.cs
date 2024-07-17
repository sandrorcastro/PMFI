using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class Contas2022
    {
        public string? CdClasse { get; set; }
        public string? CdGrupo { get; set; }
        public string? CdSubGrupo { get; set; }
        public string? CdTitulo { get; set; }
        public string? CdSubTitulo { get; set; }
        public string? CdItem { get; set; }
        public string? CdSubItem { get; set; }
        public string? CdNivel8 { get; set; }
        public string? CdNivel9 { get; set; }
        public string? CdNivel10 { get; set; }
        public string? CdNivel11 { get; set; }
        public string? CdNivel12 { get; set; }
        public short? NrAno { get; set; }
        public string? Codigo { get; set; }
        public string? DsTitulo { get; set; }
        public string? TpNaturezaSaldo { get; set; }
        public string? FlEscrituracao { get; set; }
        public string? TpNaturezaInformacao { get; set; }
        public string TpIndicSupFinanc { get; set; } = null!;
        public string? TpControle { get; set; }
        public string? Funcao { get; set; }
    }
}
