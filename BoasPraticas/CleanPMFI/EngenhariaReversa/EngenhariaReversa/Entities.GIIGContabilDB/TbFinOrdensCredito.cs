using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinOrdensCredito
    {
        public TbFinOrdensCredito()
        {
            TbFinOrdensCreditosDetalhes = new HashSet<TbFinOrdensCreditosDetalhe>();
        }

        public int IdOrdemCredito { get; set; }
        public int? IdArquivo { get; set; }
        public short? IdEmpresa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? NrAno { get; set; }
        public int? NrSequencia { get; set; }
        public int? NrSequenciaRpt { get; set; }
        public DateTime? DtOrdemCredito { get; set; }
        public int? IdCcempresa { get; set; }
        public int? IdCcarrecadadora { get; set; }
        public decimal? VlRetencoes { get; set; }
        public decimal? VlOrdemCredito { get; set; }
        public string? DsSituacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsTipo { get; set; }
        public string? DsLogin { get; set; }
        public int? NrSeqExclusao { get; set; }
        public string? Dsjustificativa { get; set; }
        public DateTime? DtExclusao { get; set; }
        public string? DsloginExclusao { get; set; }
        public string? DsFonte { get; set; }
        public int? IdAutorizacao { get; set; }
        public DateTime? DtInclusaoRpt { get; set; }
        public string? DsLoginRpt { get; set; }
        public int? NrSequenciaRe { get; set; }
        public DateTime? DtReferencia { get; set; }
        public string? DsObservacao { get; set; }
        public string? DsTipoTransferencia { get; set; }
        public string? CdOrgaoTranferencia { get; set; }
        public string? CdUnidadeTranferencia { get; set; }

        public virtual TbGerContasCorrente? IdCcempresaNavigation { get; set; }
        public virtual ICollection<TbFinOrdensCreditosDetalhe> TbFinOrdensCreditosDetalhes { get; set; }
    }
}
