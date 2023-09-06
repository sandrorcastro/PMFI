using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciSolicitacaoDespachoAnexo
    {
        public int IdSolicitacaoDespachoAnexo { get; set; }
        public int IdSolicitacaoDespacho { get; set; }
        public string? NmAnexo { get; set; }
        public byte[]? BnObjeto { get; set; }
        public string? DsExtencao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? FlEncaminhaSolicitante { get; set; }

        public virtual TbAciSolicitacaoDespacho IdSolicitacaoDespachoNavigation { get; set; } = null!;
    }
}
