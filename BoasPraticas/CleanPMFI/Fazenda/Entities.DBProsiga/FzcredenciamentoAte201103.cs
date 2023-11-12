using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

/// <summary>
/// Cadastro de Credenciais Deprecated utilizado ate 10/03/2011
/// </summary>
public partial class FzcredenciamentoAte201103
{
    /// <summary>
    /// Codigo Identificacao Credencial
    /// </summary>
    public long MovCredenId { get; set; }

    /// <summary>
    /// Numero da Credencial
    /// </summary>
    public long CredenNum { get; set; }

    /// <summary>
    /// Tipo do Veículo
    /// </summary>
    public int? FztipoVeicId { get; set; }

    /// <summary>
    /// ID do Veiculo Credenciado
    /// </summary>
    public long? FzveiId { get; set; }

    /// <summary>
    /// Data Emissao Credencial
    /// </summary>
    public DateTime? CredenDtEm { get; set; }

    /// <summary>
    /// Data de Vencimento da Credencial
    /// </summary>
    public DateTime? CredenDtVenc { get; set; }

    /// <summary>
    /// Tipo do Movimento da credencial, pode ser &quot;PROVISÓRIA&quot; ou &quot;DEFINITIVA&quot;.
    /// </summary>
    public string CredenTipoAutorizacao { get; set; } = null!;

    /// <summary>
    /// ID Contribuinte a Credenciar
    /// </summary>
    public long? ConId { get; set; }

    public int? CredenTipoId { get; set; }

    /// <summary>
    /// Ident. de Renovação do Alvara.
    /// </summary>
    public int? RenovaId { get; set; }

    /// <summary>
    /// Observações sobre a credencial.
    /// </summary>
    public string? CredenObs { get; set; }

    /// <summary>
    /// Situação da Credencial
    /// </summary>
    public string? CredenSituacao { get; set; }

    /// <summary>
    /// Data do Curso de Motorista para o tipo de veículo especifico.
    /// </summary>
    public DateTime? CursoData { get; set; }

    /// <summary>
    /// Validade do Curso
    /// </summary>
    public DateTime? CursoValidade { get; set; }

    /// <summary>
    /// Data da Emissão da Certidão de Antecedentes Criminais
    /// </summary>
    public DateTime? CertAntecCriminaisData { get; set; }

    /// <summary>
    /// Numero do NIT do Condutor
    /// </summary>
    public string? Nitnumero { get; set; }

    /// <summary>
    /// Data de Pagto da Taxa de INSS para exercício de atividades
    /// </summary>
    public DateTime? TaxaInssdtPagto { get; set; }

    public string? CadastroDesuso { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual FztipoCredenciamento? CredenTipo { get; set; }

    public virtual TribAlvaraRenovacao? Renova { get; set; }
}
