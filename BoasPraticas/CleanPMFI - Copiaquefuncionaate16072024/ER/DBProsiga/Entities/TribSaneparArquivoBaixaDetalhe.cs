using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribSaneparArquivoBaixaDetalhe
{
    public long SaneDetId { get; set; }

    public int? SaneArqId { get; set; }

    public string? SaneDetMunicipio { get; set; }

    public string? SaneDetLocal { get; set; }

    public string? SaneDetMatricula { get; set; }

    public string? SaneDetNome { get; set; }

    public string? SaneDetTipoCpfcnpj { get; set; }

    public string? SaneDetCpfcnpj { get; set; }

    public string? SaneDetQuadrante { get; set; }

    public string? SaneDetQuadricula { get; set; }

    public string? SaneDetSetor { get; set; }

    public string? SaneDetQuadra { get; set; }

    public string? SaneDetLote { get; set; }

    public string? SaneDetLogradouro { get; set; }

    public string? SaneDetNumeroImovel { get; set; }

    public string? SaneDetCategoria { get; set; }

    public string? SaneDetAresidencial { get; set; }

    public string? SaneDetAcomercial { get; set; }

    public string? SaneDetAindustrial { get; set; }

    public string? SaneDetAutilidadePublica { get; set; }

    public string? SaneDetApoderPublico { get; set; }

    public string? SaneDetEresidencial { get; set; }

    public string? SaneDetEcomercial { get; set; }

    public string? SaneDetEindustrial { get; set; }

    public string? SaneDetEutilidadePublica { get; set; }

    public string? SaneDetEpoderPublico { get; set; }

    public string? SaneDetReferencia { get; set; }

    public string? SaneDetDigito { get; set; }

    public string? SaneDetReferenciaMulta { get; set; }

    public string? SaneDetCodServico { get; set; }

    public decimal? SaneDetValor { get; set; }

    public DateTime? SaneDetDataPagamento { get; set; }

    public string? SaneDetClasseLixo { get; set; }

    public string? SaneDetProcessado { get; set; }

    public string? SaneDetDescricaoErro { get; set; }

    public string? SaneDetUsuario { get; set; }

    public DateTime? SaneDetDataInclusao { get; set; }

    public virtual TribSaneparArquivoBaixa? SaneArq { get; set; }

    public virtual ICollection<TribSaneparDivida> TribSaneparDivida { get; set; } = new List<TribSaneparDivida>();
}
