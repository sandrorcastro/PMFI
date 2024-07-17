using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwGeomaisCadastroImovelRemover
    {
        public string NrCadastroImobiliario { get; set; } = null!;
        public string? CdDistrito { get; set; }
        public string? CdSetor { get; set; }
        public string? NrQuadra { get; set; }
        public string? NrLote { get; set; }
        public string NrEdificacao { get; set; } = null!;
        public string? NrUnidade { get; set; }
        public string CdItem { get; set; } = null!;
        public string CdSubItem { get; set; } = null!;
        public string VlrItem { get; set; } = null!;
        public string DtItem { get; set; } = null!;
        public string TextoItem { get; set; } = null!;
    }
}
