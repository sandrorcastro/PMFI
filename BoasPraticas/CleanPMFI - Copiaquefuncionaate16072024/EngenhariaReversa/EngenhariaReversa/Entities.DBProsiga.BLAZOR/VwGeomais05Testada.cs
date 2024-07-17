using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwGeomais05Testada
    {
        public long NrCadastroImobiliario { get; set; }
        public string? CdDistrito { get; set; }
        public string? CdSetor { get; set; }
        public string? NrQuadra { get; set; }
        public string? NrLote { get; set; }
        public int NrTestada { get; set; }
        public int CdLogradouro { get; set; }
        public int? CdSecao { get; set; }
        public int? CdLadoSecao { get; set; }
        public decimal? MdTestada { get; set; }
        public int? Origem { get; set; }
    }
}
