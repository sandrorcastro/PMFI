using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspEstornosEmpenho
    {
        public TbDspEstornosEmpenho()
        {
            TbDspEstornosEmpenhoItens = new HashSet<TbDspEstornosEmpenhoIten>();
            TbDspReversaoEstornos = new HashSet<TbDspReversaoEstorno>();
        }

        public int IdEstorno { get; set; }
        public int IdEmpenho { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrSequencia { get; set; }
        public short? NrSequenciaAnual { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsMotivo { get; set; }
        public decimal? VlSaldoAntDotacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdEstornoLiquidacao { get; set; }
        public short? IdTipoEstornoEmpenho { get; set; }

        public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;
        public virtual TbGerEmpresasGoverno? IdEmpresaNavigation { get; set; }
        public virtual TbDspTiposEstornoEmpenho? IdTipoEstornoEmpenhoNavigation { get; set; }
        public virtual ICollection<TbDspEstornosEmpenhoIten> TbDspEstornosEmpenhoItens { get; set; }
        public virtual ICollection<TbDspReversaoEstorno> TbDspReversaoEstornos { get; set; }
    }
}
