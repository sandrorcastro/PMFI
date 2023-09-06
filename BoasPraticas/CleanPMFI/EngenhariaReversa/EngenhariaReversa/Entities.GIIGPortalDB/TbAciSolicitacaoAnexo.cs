using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciSolicitacaoAnexo
    {
        public int IdSolicitacaoAnexo { get; set; }
        public int IdSolicitacao { get; set; }
        public string? NmAnexo { get; set; }
        public byte[]? BnObjeto { get; set; }
        public string? DsExtencao { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbAciSolicitacao IdSolicitacaoNavigation { get; set; } = null!;
    }
}
