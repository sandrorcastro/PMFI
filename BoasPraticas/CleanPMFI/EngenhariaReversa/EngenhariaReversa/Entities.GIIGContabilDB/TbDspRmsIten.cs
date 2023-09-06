using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspRmsIten
    {
        public int IdRms { get; set; }
        public int IdItem { get; set; }
        public int? IdLicitacaoItem { get; set; }
        public int? IdContratoItemLicitacao { get; set; }
        public decimal? NrQtde { get; set; }
        public string? DsComplemento { get; set; }
        public decimal? VlEstimadoUnitario { get; set; }
        public decimal? VlEstimadoTotal { get; set; }
        public int? IdCotacaoSimples { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public int? IdCotacao { get; set; }
        public int? IdNatDespesa { get; set; }

        public virtual TbDspIten IdItemNavigation { get; set; } = null!;
        public virtual TbDspRm IdRmsNavigation { get; set; } = null!;
    }
}
