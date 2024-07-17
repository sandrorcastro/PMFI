using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VwMapaBaixaParcelamento
    {
        public long Tapmapaid { get; set; }
        public long? TapId { get; set; }
        public long? Tapnumero { get; set; }
        public int? AnoDivida { get; set; }
        public int? TipoTribId { get; set; }
        public string? Tributo { get; set; }
        public decimal? PrincipalOriginal { get; set; }
        public decimal? CorrecaoOriginal { get; set; }
        public decimal? PrincipalBaixado { get; set; }
        public decimal? JurosBaixado { get; set; }
        public decimal? MultaBaixada { get; set; }
        public decimal? MultaDa { get; set; }
        public decimal? CorrecaoBaixada { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? JurosParcelamento { get; set; }
        public string Situacao { get; set; } = null!;
        public string? DataBaixa { get; set; }
        public decimal? TapValorPagamentoParcial { get; set; }
        public decimal? JurosTap { get; set; }
        public decimal? MultaTap { get; set; }
        public decimal? CorrecaoTap { get; set; }
        public decimal? MultaDaTap { get; set; }
        public decimal? DescontoTap { get; set; }
    }
}
