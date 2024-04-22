using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwGeomais04CadastroUnidade
    {
        public string NrCadastroImobiliario { get; set; } = null!;
        public long IdLote { get; set; }
        public string? CdDistrito { get; set; }
        public string? CdSetor { get; set; }
        public string? NrQuadra { get; set; }
        public string? NrLote { get; set; }
        public string? NrUnidade { get; set; }
        public int CdItem { get; set; }
        public int CdSubItem { get; set; }
        public int? VlrItem { get; set; }
        public string DtItem { get; set; } = null!;
        public string? TextoItem { get; set; }
    }
}
