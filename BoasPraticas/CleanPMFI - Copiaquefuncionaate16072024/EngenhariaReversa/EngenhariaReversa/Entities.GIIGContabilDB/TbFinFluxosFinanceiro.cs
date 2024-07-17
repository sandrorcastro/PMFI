using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinFluxosFinanceiro
    {
        public TbFinFluxosFinanceiro()
        {
            TbFinFluxosFinanDetalhes = new HashSet<TbFinFluxosFinanDetalhe>();
        }

        public int IdFluxo { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgao { get; set; }
        public int? IdFonte { get; set; }
        public DateTime? DtLancamento { get; set; }
        public decimal? VlMovimento { get; set; }
        public short? NrParcelas { get; set; }
        public string? DsTipoOperacao { get; set; }
        public string? DsTipoLancamento { get; set; }
        public string? DsHistorico { get; set; }
        public string? DsObjeto { get; set; }
        public int? IdObjeto { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public bool? FlExcluido { get; set; }
        public DateTime? DtExclusao { get; set; }
        public string? DsMotivoExclusao { get; set; }
        public string? DsLoginExclusao { get; set; }

        public virtual ICollection<TbFinFluxosFinanDetalhe> TbFinFluxosFinanDetalhes { get; set; }
    }
}
