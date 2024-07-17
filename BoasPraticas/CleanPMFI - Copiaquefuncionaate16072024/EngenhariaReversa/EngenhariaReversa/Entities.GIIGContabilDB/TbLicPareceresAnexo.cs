using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicPareceresAnexo
    {
        public int IdAnexo { get; set; }
        public int? IdLicitacao { get; set; }
        public string? NmAnexo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public byte[]? BnObjeto { get; set; }
        public string? DsExtencao { get; set; }
        public string? DsLogin { get; set; }
        public string? FlPublicaPortalTransparencia { get; set; }
        public string? FlPublicaPortalFornecedor { get; set; }
        public string? DsAnexo { get; set; }

        public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }
    }
}
