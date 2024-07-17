using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

/// <summary>
/// Cadastro e Manutenção de Vistorias  Efetuadas em Veiculos no Foztrans.
/// </summary>
public partial class FzvistoriaVeiculo
{
    /// <summary>
    /// Código de Identificação da Vistoria do Veiculo.
    /// </summary>
    public long VistId { get; set; }

    /// <summary>
    /// Código de Identificação do Veiculo Vistoriado.
    /// </summary>
    public long? FzveiId { get; set; }

    /// <summary>
    /// Tipo do Veiculo sendo Vistoriado. 
    /// </summary>
    public int? FztipoVeicId { get; set; }

    /// <summary>
    /// Numero do Selo de Vistoria ou Numero de Sequencia Anual de Vistorias Emitidas por Tipo de Veículo no Ano.
    /// </summary>
    public int? FztipoVeicNrSeqAnual { get; set; }

    /// <summary>
    /// Código de Identificação do Proprietário do Veículo na Data da Vistoria.
    /// </summary>
    public long? FzproprietarioId { get; set; }

    /// <summary>
    /// Código de Identificação do Ponto do Veículo na data da Vistoria.
    /// </summary>
    public long? FzpontoId { get; set; }

    /// <summary>
    /// Codigo de Identificação do Tipo de Vistoria.
    /// </summary>
    public long? FztipoVistId { get; set; }

    /// <summary>
    /// Código de identificação do fiscal que efetuou a Vistoria no Veículo.
    /// </summary>
    public long? FiscId { get; set; }

    /// <summary>
    /// Data da Vistoria no Veículo.
    /// </summary>
    public DateTime? VistData { get; set; }

    /// <summary>
    /// Data de Validade da Vistoria efetuada em Veiculo.
    /// </summary>
    public DateTime? VistDataValidade { get; set; }

    /// <summary>
    /// Data da Inspeção Técnica Veicular. ANTT-Campo em teste e dispensado pelo Elvis em 13/10/2021 16:15 hs
    /// </summary>
    public DateTime? Citvdata { get; set; }

    /// <summary>
    /// Data do Vencimento da Inspeção Técnica Veicular. ANTT-Campo em teste e dispensado pelo Elvis em 13/10/2021 16:15 hs
    /// </summary>
    public DateTime? CitvdtValidade { get; set; }

    /// <summary>
    /// Numero do Selo de Aprovação da Inspeção Técnica Veicular. ANTT-Campo em teste e dispensado pelo Elvis em 13/10/2021 16:15 hs
    /// </summary>
    public string? Saitvnumero { get; set; }

    /// <summary>
    /// Data da Validade do Selo de Aprovação da Inspeção Técnica Veicular. ANTT-Campo em teste e dispensado pelo Elvis em 13/10/2021 16:15 hs
    /// </summary>
    public DateTime? SaitvdtValidade { get; set; }

    /// <summary>
    /// Código de Identificação do Usuário que Inseriu o Registro.
    /// </summary>
    public int? UsuarioIdGravacao { get; set; }

    /// <summary>
    /// Data da Inserção do Registro
    /// </summary>
    public DateTime? DataGravacao { get; set; }

    /// <summary>
    /// Código de Identificação do Usuário que Efetuou a Ultima Alteração do Registro.
    /// </summary>
    public int? UsuarioIdUltAlt { get; set; }

    /// <summary>
    /// Data da Ultima Alteração do Registro.
    /// </summary>
    public DateTime? DataUltAlt { get; set; }

    public virtual Fzfiscai? Fisc { get; set; }

    public virtual ICollection<Fzdivida> Fzdivida { get; set; } = new List<Fzdivida>();

    public virtual ICollection<FzitensVistoriado> FzitensVistoriados { get; set; } = new List<FzitensVistoriado>();

    public virtual ICollection<FztermoVistorium> FztermoVistoria { get; set; } = new List<FztermoVistorium>();

    public virtual FztipoVistorium? FztipoVist { get; set; }

    public virtual Fzveiculo? Fzvei { get; set; }
}
