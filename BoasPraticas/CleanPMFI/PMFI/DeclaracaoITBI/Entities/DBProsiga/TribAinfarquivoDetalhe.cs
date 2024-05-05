using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAinfarquivoDetalhe
{
    public int IdainfarquivoDetalhes { get; set; }

    public int? TipoRegistro { get; set; }

    public string? Uajurisdicao { get; set; }

    public string? Nome { get; set; }

    public string? Cnpj { get; set; }

    public string? Cnae { get; set; }

    public DateOnly? DataFalencia { get; set; }

    public string? Tipologradouro { get; set; }

    public string? Logradouro { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public int? Codigomunicipio { get; set; }

    public string? Municipio { get; set; }

    public string? Uf { get; set; }

    public string? Cep { get; set; }

    public int? Tributo { get; set; }

    public int? Lancamento { get; set; }

    public int? Natureza { get; set; }

    public DateOnly? DataVencimentoprincipal { get; set; }

    public string? Umv { get; set; }

    public decimal? ValorPrincipal { get; set; }

    public DateOnly? DataPeriodoApuracao { get; set; }

    public long? Declaracao { get; set; }

    public DateOnly? DataEntregaDeclaracao { get; set; }

    public long? Processo { get; set; }

    public string? AutoInfracao { get; set; }

    public DateOnly? DataCienciaLancamento { get; set; }

    public DateOnly? DataCienciaUltimaDecisao { get; set; }

    public string? FundamentacaoLegalPrincipal { get; set; }

    public string? FundamentacaoLegalAcrescimos { get; set; }

    public int? Multademora { get; set; }

    public int? MultaOficio { get; set; }

    public DateOnly? DataVencimentoMulta { get; set; }

    public decimal? ValorMultaOficio { get; set; }

    public int? CodigoInfracao { get; set; }

    public string? ChaveCt { get; set; }

    public DateTime DataInclusao { get; set; }

    public string UsuarioInclusao { get; set; } = null!;

    public int? IdAinfarquivo { get; set; }

    public string? IsImportado { get; set; }

    public virtual TribAinfarquivo? IdAinfarquivoNavigation { get; set; }

    public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; } = new List<TribAinfarquivoDividasLancada>();
}
