using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicLicitacoesItensLote
    {
        public TbLicLicitacoesItensLote()
        {
            TbDspSolicitacoesEmpenhoItens = new HashSet<TbDspSolicitacoesEmpenhoIten>();
        }

        public int NrLote { get; set; }
        public int IdLicitacaoItem { get; set; }
        public short? NrSequencia { get; set; }
        public decimal? NrQuantidade { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbLicLicitacoesIten IdLicitacaoItemNavigation { get; set; } = null!;
        public virtual ICollection<TbDspSolicitacoesEmpenhoIten> TbDspSolicitacoesEmpenhoItens { get; set; }
    }
}
