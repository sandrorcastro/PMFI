using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelParametrizacoesDetalhe
    {
        public int IdDetalhe { get; set; }
        public int? IdGrupo { get; set; }
        public short? NrSequencia { get; set; }
        public string? NrReferencia { get; set; }
        public string? DsDetalhe { get; set; }

        public virtual TbRelParametrizacoesGrupo? IdGrupoNavigation { get; set; }
    }
}
