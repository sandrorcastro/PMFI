using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelSaldosMensaisReceita
    {
        public int IdSaldo { get; set; }
        public short NrMes { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdReceita { get; set; }
        public string? CdFonte { get; set; }
        public decimal? VlOrcado { get; set; }
        public decimal? VlReestimado { get; set; }
        public decimal? VlAtualizado { get; set; }
        public decimal? VlArrecadado { get; set; }
        public string? CdOrigem { get; set; }
        public string? CdAplicacaoFonte { get; set; }
        public string? CdDesdobramentoFonte { get; set; }
        public string? CdDetalhamentoFonte { get; set; }
        public short? TipoArrecadacao { get; set; }
    }
}
