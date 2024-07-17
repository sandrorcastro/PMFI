using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Processo
{
    /// <summary>
    /// Código de Identificação do Processo
    /// </summary>
    public long ProcId { get; set; }

    /// <summary>
    /// Identificação do Tipo do Processo
    /// </summary>
    public int? ProcTipoProcId { get; set; }

    /// <summary>
    /// Código de Identificação  do Contribuinte
    /// </summary>
    public long? ProcIdContribuinte { get; set; }

    /// <summary>
    /// Descrição do objeto do processo
    /// </summary>
    public string? ProcDescricao { get; set; }

    /// <summary>
    /// Data da entrada do processo
    /// </summary>
    public DateTime? ProcDataEntrada { get; set; }

    /// <summary>
    /// Data de encerramento do processo
    /// </summary>
    public DateTime? ProcDataEnc { get; set; }

    /// <summary>
    /// Data prevista para resposta ao contribuinte
    /// </summary>
    public DateTime? ProcDataPrevResp { get; set; }

    /// <summary>
    /// Permite ou não consulta na internet
    /// </summary>
    public string? ProcPublicaWeb { get; set; }

    /// <summary>
    /// Situação do processo
    /// </summary>
    public string? ProcSituacao { get; set; }

    /// <summary>
    /// Identificação da divisão onde o processo está
    /// </summary>
    public int? ProcDivTramitacao { get; set; }

    /// <summary>
    /// Informar se a solicitação foi ou não aprovada
    /// </summary>
    public string? ProcDeferido { get; set; }

    /// <summary>
    /// Informar se a solicitação foi ou não atendida.
    /// </summary>
    public string? ProcAtendido { get; set; }

    public int? ProcAno { get; set; }

    public long? ProcSeqAnual { get; set; }

    public long? ProcServidorId { get; set; }

    public long? ProcArquivId { get; set; }

    public DateTime? ProcDtArquivo { get; set; }

    public DateTime? ProcDtIncineracao { get; set; }

    public virtual ICollection<AlvaraConstrucaoProcesso> AlvaraConstrucaoProcessos { get; set; } = new List<AlvaraConstrucaoProcesso>();

    public virtual ICollection<CargasProcesso> CargasProcessos { get; set; } = new List<CargasProcesso>();

    public virtual ICollection<FissServicoTipoServico> FissServicoTipoServicos { get; set; } = new List<FissServicoTipoServico>();

    public virtual ICollection<LogProcesso> LogProcessos { get; set; } = new List<LogProcesso>();

    public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; } = new List<OuvidoriaProcesso>();

    public virtual ProcArquivamento? ProcArquiv { get; set; }

    public virtual Diviso? ProcDivTramitacaoNavigation { get; set; }

    public virtual Contribuinte? ProcIdContribuinteNavigation { get; set; }

    public virtual Servidore? ProcServidor { get; set; }

    public virtual TipoProcesso? ProcTipoProc { get; set; }

    public virtual ICollection<TribAdvertencia> TribAdvertencia { get; set; } = new List<TribAdvertencia>();

    public virtual ICollection<TribDividasContribuinteProcesso> TribDividasContribuinteProcessos { get; set; } = new List<TribDividasContribuinteProcesso>();

    public virtual ICollection<TribCartaHabitacao> Idcarta { get; set; } = new List<TribCartaHabitacao>();
}
