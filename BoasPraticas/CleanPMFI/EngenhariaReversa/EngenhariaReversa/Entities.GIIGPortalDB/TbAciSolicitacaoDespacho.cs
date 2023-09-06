using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciSolicitacaoDespacho
    {
        public TbAciSolicitacaoDespacho()
        {
            TbAciSolicitacaoDespachoAnexos = new HashSet<TbAciSolicitacaoDespachoAnexo>();
        }

        public int IdSolicitacaoDespacho { get; set; }
        public int IdSolicitacao { get; set; }
        public DateTime? DtDespacho { get; set; }
        public int? IdInteressadoEmitente { get; set; }
        public int? IdInteressadoRecebedor { get; set; }
        public string? DsParecer { get; set; }

        public virtual TbAciInteressado? IdInteressadoRecebedorNavigation { get; set; }
        public virtual TbAciSolicitacao IdSolicitacaoNavigation { get; set; } = null!;
        public virtual ICollection<TbAciSolicitacaoDespachoAnexo> TbAciSolicitacaoDespachoAnexos { get; set; }
    }
}
