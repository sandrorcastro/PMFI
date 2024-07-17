using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

/// <summary>
/// Cadastro e Manutenção de Credenciais Antigas. Objetiva informatização de Credenciamento armazenados em fichas manuais. 
/// </summary>
public partial class FzcredencialAncient
{
    /// <summary>
    /// Código de Identificação do Credenciamento de Fichas Manuais.
    /// </summary>
    public int CacredencialAncientId { get; set; }

    /// <summary>
    /// Codigo de Identificação do Tipo do Credenciamento.  FZTipoCredenciamento --&gt; 1-Permissionario / 2-Colaborador / 3-Turnante.
    /// </summary>
    public int? CacredencialTipoId { get; set; }

    /// <summary>
    /// Código de Identificação do Condutor do Veículo na data do Credenciamento.
    /// </summary>
    public long? CacondutorId { get; set; }

    /// <summary>
    /// Nome do Condutor. Campo Obrigatório.
    /// </summary>
    public string? CacondutorNome { get; set; }

    /// <summary>
    /// CPF do Condutor
    /// </summary>
    public string? CacondutorCpf { get; set; }

    /// <summary>
    /// Data do Credenciamento
    /// </summary>
    public DateTime? CacredencialData { get; set; }

    /// <summary>
    /// Validade do Credenciamento
    /// </summary>
    public DateTime? CacredencialDtValidade { get; set; }

    /// <summary>
    /// Código de Identificação do Veículo sendo credenciado.
    /// </summary>
    public long? CaveiculoId { get; set; }

    /// <summary>
    /// Placa do Veículo. Utilizada para cadastramento no caso do veículo nao existir no cenário atual. Campo Obrigatório.
    /// </summary>
    public string? CaveiculoPlaca { get; set; }

    /// <summary>
    /// Código de Identificação do Permissionário (Proprietário) do Veículo.
    /// </summary>
    public long? CapermissionarioId { get; set; }

    /// <summary>
    /// Nome do Permissionario (Proprietário) do Veículo.
    /// </summary>
    public string? CapermissionarioNome { get; set; }

    /// <summary>
    /// Código de Identificação do Ponto ao qual pertence o Veículo na data do credenciamento.
    /// </summary>
    public long? CapontoId { get; set; }

    /// <summary>
    /// Nome do Ponto.
    /// </summary>
    public string? CapontoNome { get; set; }

    /// <summary>
    /// Informações Complementares a respeito do credenciamento.
    /// </summary>
    public string? Caobservacoes { get; set; }

    /// <summary>
    /// Data da Inclusão do Credenciamento no Sistema.
    /// </summary>
    public DateTime? CadataInclusao { get; set; }

    /// <summary>
    /// Nome do Usuario que efetuou a inclusão de dados no sistema.
    /// </summary>
    public string? CausuarioInclusao { get; set; }

    public virtual Contribuinte? Cacondutor { get; set; }

    public virtual FztipoCredenciamento? CacredencialTipo { get; set; }

    public virtual Contribuinte? Capermissionario { get; set; }

    public virtual Fzponto? Caponto { get; set; }

    public virtual Fzveiculo? Caveiculo { get; set; }
}
