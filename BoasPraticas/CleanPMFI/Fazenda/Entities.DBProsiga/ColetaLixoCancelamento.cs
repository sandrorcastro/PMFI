using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ColetaLixoCancelamento
{
    public long ProcId { get; set; }

    public int? ProcTipoProcId { get; set; }

    public long? ProcIdContribuinte { get; set; }

    public string? ProcDescricao { get; set; }

    public DateTime? ProcDataEntrada { get; set; }

    public DateTime? ProcDataEnc { get; set; }

    public DateTime? ProcDataPrevResp { get; set; }

    public string? ProcPublicaWeb { get; set; }

    public string? ProcSituacao { get; set; }

    public int? ProcDivTramitacao { get; set; }

    public string? ProcDeferido { get; set; }

    public string? ProcAtendido { get; set; }

    public int? ProcAno { get; set; }

    public long? ProcSeqAnual { get; set; }

    public long? ProcServidorId { get; set; }

    public long? ProcArquivId { get; set; }

    public DateTime? ProcDtArquivo { get; set; }

    public DateTime? ProcDtIncineracao { get; set; }
}
