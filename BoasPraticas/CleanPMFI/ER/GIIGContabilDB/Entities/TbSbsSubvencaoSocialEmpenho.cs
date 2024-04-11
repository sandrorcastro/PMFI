using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsSubvencaoSocialEmpenho
{
    public int IdSubVencaoSocial { get; set; }

    public int IdEmpenho { get; set; }

    public int? IdPessoa { get; set; }

    public string? NrProtocolo { get; set; }

    public DateTime? DtProtocolo { get; set; }

    public string? DsSetorArquivamento { get; set; }

    public virtual TbDspEmpenho IdEmpenhoNavigation { get; set; } = null!;

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }

    public virtual TbSbsSubvencaoSocial IdSubVencaoSocialNavigation { get; set; } = null!;
}
