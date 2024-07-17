using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCapEstornosExecucaoAntecipadum
    {
        public int IdEstorno { get; set; }
        public int IdExecucao { get; set; }
        public short? NrEstorno { get; set; }
        public short? NrAnoEstorno { get; set; }
        public DateTime? DtEstorno { get; set; }
        public decimal? VlEstorno { get; set; }
        public string? DsMotivo { get; set; }
        /// <summary>
        /// Id do Lançamento contabil estornado
        /// </summary>
        public int? IdLancamentoEstorno { get; set; }
        public int? IdEmpresa { get; set; }

        public virtual TbCapExecucaoAntecipadum IdExecucaoNavigation { get; set; } = null!;
    }
}
