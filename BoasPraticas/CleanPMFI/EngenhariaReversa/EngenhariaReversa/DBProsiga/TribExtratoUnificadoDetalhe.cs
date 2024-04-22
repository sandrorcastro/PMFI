using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribExtratoUnificadoDetalhe
    {
        public string Sessao { get; set; } = null!;
        public string TipoCadastro { get; set; } = null!;
        public long Idinscricao { get; set; }
        public long? Iddivida { get; set; }
        public short? Ano { get; set; }
        public string? Tributo { get; set; }
        public int? SubDivida { get; set; }
        public string? Parcela { get; set; }
        public int? Mes { get; set; }
        public DateTime? Vencimento { get; set; }
        public string? TipoDivida { get; set; }
        public string? TipoBaixa { get; set; }
        public string? Revisão { get; set; }
        public decimal? VlrPrincipal { get; set; }
        public decimal? VlrCorrecao { get; set; }
        public decimal? VlrMulta { get; set; }
        public decimal? VlrMultaDa { get; set; }
        public decimal? VlrJuros { get; set; }
        public decimal? VlrDesconto { get; set; }
        public DateTime? DataBaixa { get; set; }
        public decimal? VlrBaixa { get; set; }
        public string? Cda { get; set; }
        public string? ParcelaUnica { get; set; }
        public string? NrProcesso { get; set; }
    }
}
