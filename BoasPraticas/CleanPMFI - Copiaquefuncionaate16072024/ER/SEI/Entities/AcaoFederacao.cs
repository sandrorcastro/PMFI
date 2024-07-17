using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AcaoFederacao
{
    public string IdAcaoFederacao { get; set; } = null!;

    public string IdInstalacaoFederacao { get; set; } = null!;

    public string IdOrgaoFederacao { get; set; } = null!;

    public string IdUnidadeFederacao { get; set; } = null!;

    public string IdUsuarioFederacao { get; set; } = null!;

    public string? IdProcedimentoFederacao { get; set; }

    public string? IdDocumentoFederacao { get; set; }

    public DateTime DthGeracao { get; set; }

    public DateTime? DthAcesso { get; set; }

    public int StaTipo { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<ParametroAcaoFederacao> ParametroAcaoFederacaos { get; set; } = new List<ParametroAcaoFederacao>();
}
