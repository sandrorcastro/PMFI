using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class RelTribLivroInscrDatemp
    {
        public int? InscrDa { get; set; }
        public string? Inscricao { get; set; }
        public int? Mes { get; set; }
        public int? SubDivida { get; set; }
        public int? Parcela { get; set; }
        public DateTime? Vencimento { get; set; }
        public decimal? Valor { get; set; }
        public decimal? MultaDa { get; set; }
        public long? Livro { get; set; }
        public int? Folha { get; set; }
        public DateTime? DataInscricao { get; set; }
        public string? Contribuinte { get; set; }
        public int? Ano { get; set; }
        public int? Tributo { get; set; }
        public string? NomeTributo { get; set; }
        public string? Situacao { get; set; }
        public string? TipoCadastro { get; set; }
        public int? LivroDaanoTermo { get; set; }
        public int? LivroDanumeroTermo { get; set; }
        public string? SituacaoDiv { get; set; }
        public string? Sessao { get; set; }
    }
}
