using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicLicitacoesUsuario
    {
        public int IdLicitacao { get; set; }
        public string DsLogin { get; set; } = null!;
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;
    }
}
