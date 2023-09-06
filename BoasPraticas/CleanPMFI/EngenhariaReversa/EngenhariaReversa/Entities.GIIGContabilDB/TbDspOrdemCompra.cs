using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspOrdemCompra
    {
        public TbDspOrdemCompra()
        {
            TbDspOrdemComprasItens = new HashSet<TbDspOrdemComprasIten>();
        }

        public int IdOrdemCompra { get; set; }
        public int IdEmpenho { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencia { get; set; }
        public DateTime? DtCompra { get; set; }
        public decimal? VlCompra { get; set; }
        public string? DsSituacao { get; set; }
        public string? DsHistorico { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdLiquidacaoDocto { get; set; }
        public string? DsLocalEntrega { get; set; }
        public DateTime? DtPrazoEntrega { get; set; }
        public string? DsPrazoEntrega { get; set; }
        public string? DsFormaPagamento { get; set; }
        public string? DsObservacoes { get; set; }

        public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
        public virtual ICollection<TbDspOrdemComprasIten> TbDspOrdemComprasItens { get; set; }
    }
}
