using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcAtosAlteracoesErrata
    {
        public int IdErrata { get; set; }
        public int IdAtoAlteracao { get; set; }
        public int? IdAlteracao { get; set; }
        public int? IdTipoRevisao { get; set; }
        public decimal? VlRevisao { get; set; }
        public DateTime? DtErrata { get; set; }
        public string? DsMotivo { get; set; }
        public string? DsLogin { get; set; }
    }
}
