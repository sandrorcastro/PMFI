using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbTcmMatrizSaldosContasContabei
    {
        public int IdMatrizDespesa { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public int? NrMes { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdContaContabil { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? DsTipoValor { get; set; }
        public string? TpNaturezaValor { get; set; }
        public string? DsPoderOrgao { get; set; }
        public string? TpSuperavitFinanceiro { get; set; }
        public string? FlDividaConsolidada { get; set; }
        public string? CdFonte { get; set; }
        public string? CdReceita { get; set; }
        public string? CdNatDespesa { get; set; }
        public string? DsFuncaoSubFuncao { get; set; }
        public short? NrOrdemExibicao { get; set; }
    }
}
