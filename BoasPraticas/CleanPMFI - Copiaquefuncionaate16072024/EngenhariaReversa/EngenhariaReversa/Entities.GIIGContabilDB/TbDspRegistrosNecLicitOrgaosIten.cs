using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspRegistrosNecLicitOrgaosIten
    {
        public int IdRegistroOrgao { get; set; }
        public int IdItem { get; set; }
        public decimal? NrQuantidade { get; set; }
        public decimal? NrQtdeAlterada { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public bool? FlCriador { get; set; }

        public virtual TbDspIten IdItemNavigation { get; set; } = null!;
        public virtual TbDspRegistrosNecLicitacoesOrgao IdRegistroOrgaoNavigation { get; set; } = null!;
    }
}
