using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class Encerramento
    {
        public string TipoDeclaracao { get; set; } = null!;
        public int NrEncerramento { get; set; }
        public int NrDeclaracao { get; set; }
        public int? NrNotaFiscal { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public string RegimePrestador { get; set; } = null!;
        public string? IdServico { get; set; }
        public string? NomePrestador { get; set; }
        public string? CnpjPrestador { get; set; }
        public string? CmcTomador { get; set; }
        public string? CidadeTomador { get; set; }
        public string? CidadePrestacao { get; set; }
        public string RegimeNota { get; set; } = null!;
        public decimal? Aliquota { get; set; }
        public decimal? BaseCalculo { get; set; }
        public string? IssRetido { get; set; }
        public decimal? VlTotalIss { get; set; }
        public decimal? VlIssRetido { get; set; }
        public decimal? VlServicos { get; set; }
        public decimal? VlLiquido { get; set; }
        public int? IdDivida { get; set; }
        public long IdDividaEmpresa { get; set; }
        public long? CmcEmpresa { get; set; }
        public int? AnoDividaEmpresa { get; set; }
        public int? MesDividaEmpresa { get; set; }
        public int? IdTipoTributo { get; set; }
        public string? TipoTribNome { get; set; }
        public DateTime? DataVencimentoDivida { get; set; }
        public DateTime? DataGeracaoDivida { get; set; }
        public int? IdBaixa { get; set; }
        public string? TipoNomeBaixa { get; set; }
        public decimal ValorBaixaDividaEmpresa { get; set; }
        public DateTime? EmprDivDataBaixa { get; set; }
        public decimal ValorDividaEmpresa { get; set; }
        public string? NomeContribuinte { get; set; }
        public string? CpfCnpjContribuinte { get; set; }
    }
}
