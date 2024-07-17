using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspSolicitacoesEmpenhoIten
    {
        public int IdSolicitacaoEmpenhoItem { get; set; }
        public int IdSolicitacaoEmpenho { get; set; }
        public int? IdLicitacaoItem { get; set; }
        public int? NrLote { get; set; }
        public int? IdItem { get; set; }
        public decimal? NrQtde { get; set; }
        public string? DsItemCompl { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public int? IdNatDespesa { get; set; }

        public virtual TbDspIten? IdItemNavigation { get; set; }
        public virtual TbDspSolicitacoesEmpenho IdSolicitacaoEmpenhoNavigation { get; set; } = null!;
        public virtual TbLicLicitacoesItensLote? TbLicLicitacoesItensLote { get; set; }
    }
}
