using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwGeomaisItemCadastroImovel
    {
        public string NrCadastroImobiliario { get; set; } = null!;
        public string? CdDistrito { get; set; }
        public string? CdSetor { get; set; }
        public string? NrQuadra { get; set; }
        public string? NrLote { get; set; }
        public string NrEdificacao { get; set; } = null!;
        public string? NrUnidade { get; set; }
        public int CdItem { get; set; }
        public int CdSubItem { get; set; }
        public int? VlrItem { get; set; }
        public string DtItem { get; set; } = null!;
        public string? TextoItem { get; set; }
    }
}
