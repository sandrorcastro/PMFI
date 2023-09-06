using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciInteressado
    {
        public TbAciInteressado()
        {
            TbAciSolicitacaoDespachos = new HashSet<TbAciSolicitacaoDespacho>();
            IdUnidades = new HashSet<TbAciUnidade>();
        }

        public int IdInteressado { get; set; }
        public string? NmInteressado { get; set; }
        public string? DsEmail { get; set; }
        public int? IdProtocolo { get; set; }

        public virtual ICollection<TbAciSolicitacaoDespacho> TbAciSolicitacaoDespachos { get; set; }

        public virtual ICollection<TbAciUnidade> IdUnidades { get; set; }
    }
}
