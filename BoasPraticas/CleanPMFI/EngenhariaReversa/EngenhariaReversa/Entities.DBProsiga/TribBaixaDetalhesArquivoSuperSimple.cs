using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribBaixaDetalhesArquivoSuperSimple
    {
        public int DetalheId { get; set; }
        public int? ArquivoId { get; set; }
        public DateTime? DataArrecad { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string? Cnpjcontrib { get; set; }
        public string? Receita { get; set; }
        public string? Competencia { get; set; }
        public decimal? ValorPrincipal { get; set; }
        public decimal? ValorMulta { get; set; }
        public decimal? ValorJuros { get; set; }
        public decimal? ValorAutenticado { get; set; }
        public string? AutentBanco { get; set; }
        public string? BancoRec { get; set; }
        public string? AgenciaRec { get; set; }
        public string? IdentificacaoGuia { get; set; }
        public string? Situacao { get; set; }
        public string? Obs { get; set; }
        /// <summary>
        /// NovaDivida,AlteracaoValor,BaixaFiss
        /// </summary>
        public string? OperacaoBaixa { get; set; }
        public long? EmpIddivida { get; set; }
        public long? ConIddivida { get; set; }

        public virtual TribBaixaArquivoSuperSimple? Arquivo { get; set; }
    }
}
