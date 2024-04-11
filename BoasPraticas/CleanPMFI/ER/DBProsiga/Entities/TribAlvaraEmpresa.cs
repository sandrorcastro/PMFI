using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAlvaraEmpresa
{
    public long AlvaraId { get; set; }

    /// <summary>
    /// Inicial / Renovação / Alteração
    /// </summary>
    public string? AlvTipoAlvara { get; set; }

    public int AlvAno { get; set; }

    public long AlvNumero { get; set; }

    public DateTime? AlvData { get; set; }

    public string? AlvAtivContratoSoc { get; set; }

    public string? AlvRazaoSocial { get; set; }

    public long? EmprCmc { get; set; }

    public string? AlvCnpjcpf { get; set; }

    public DateTime? AlvDataInicial { get; set; }

    public DateTime? AlvDataFinal { get; set; }

    public string? AlvNomeFantasia { get; set; }

    public string? AlvEndereco { get; set; }

    public string? AlvNumeroLograd { get; set; }

    public string? AlvComplemento { get; set; }

    public string? AlvBairro { get; set; }

    public decimal? AlvAreaAberta { get; set; }

    public decimal? AlvAreaConstruida { get; set; }

    /// <summary>
    /// Informa se as taxas serão recalculadas ou não
    /// </summary>
    public string AlvRecalcular { get; set; } = null!;

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public short? Idmoeda { get; set; }

    public string? AlvMsgRodape { get; set; }

    public string? AlvTexto { get; set; }

    public string? AlvTitulo { get; set; }

    public string? AlvCargoAss { get; set; }

    public string? AlvNomeAss { get; set; }

    public string? AlvRestricoes { get; set; }

    public long? ServId { get; set; }

    public string? AlvProtocolo { get; set; }

    public int? TalvId { get; set; }

    public string? AlvNomeRespTecnico { get; set; }

    public string? AlvNumRegRespTecnico { get; set; }

    public string? AlvSecretaria { get; set; }

    public string? AlvDepartamento { get; set; }

    public string? AlvCnae { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }

    public virtual ICollection<TribAlvaraRenovacaoDivida> TribAlvaraRenovacaoDivida { get; set; } = new List<TribAlvaraRenovacaoDivida>();

    public virtual ICollection<TribAlvaraRenovacao> TribAlvaraRenovacaos { get; set; } = new List<TribAlvaraRenovacao>();
}
