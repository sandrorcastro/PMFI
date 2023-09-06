using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelSaldosMensaisRap
    {
        public int IdSaldo { get; set; }
        public short? NrMes { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrExercicio { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdFuncao { get; set; }
        public string? CdSubFuncao { get; set; }
        public string? CdNatDespesa { get; set; }
        public string? CdFonte { get; set; }
        public string? CdCatDespesa { get; set; }
        public string? CdGrupoDespesa { get; set; }
        public string? CdModalidade { get; set; }
        public string? CdElemento { get; set; }
        public string? CdDesdobramento { get; set; }
        public string? CdDetalhamento { get; set; }
        public decimal? VlInscritoProcessado { get; set; }
        public decimal? VlInscritoNaoProcessado { get; set; }
        public decimal? VlPagoProcessados { get; set; }
        public decimal? VlPagoNaoProcessados { get; set; }
        public decimal? VlCanceladoProcessados { get; set; }
        public decimal? VlCanceladoNaoProcessados { get; set; }
        public string? CdOrigem { get; set; }
        public string? CdAplicacaoFonte { get; set; }
        public string? CdDesdobramentoFonte { get; set; }
        public string? CdDetalhamentoFonte { get; set; }
        public decimal? VlLiquidadoNaoProcessadosPeriodo { get; set; }
    }
}
