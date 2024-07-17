using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AcessoFederacao
{
    public string IdAcessoFederacao { get; set; } = null!;

    public string IdInstalacaoFederacaoRem { get; set; } = null!;

    public string IdOrgaoFederacaoRem { get; set; } = null!;

    public string IdUnidadeFederacaoRem { get; set; } = null!;

    public string? IdUsuarioFederacaoRem { get; set; }

    public string IdInstalacaoFederacaoDest { get; set; } = null!;

    public string IdOrgaoFederacaoDest { get; set; } = null!;

    public string IdUnidadeFederacaoDest { get; set; } = null!;

    public string? IdUsuarioFederacaoDest { get; set; }

    public string IdProcedimentoFederacao { get; set; } = null!;

    public string? IdDocumentoFederacao { get; set; }

    public DateTime DthLiberacao { get; set; }

    public string? MotivoLiberacao { get; set; }

    public DateTime? DthCancelamento { get; set; }

    public string? MotivoCancelamento { get; set; }

    public int StaTipo { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual ProtocoloFederacao? IdDocumentoFederacaoNavigation { get; set; }

    public virtual InstalacaoFederacao IdInstalacaoFederacaoDestNavigation { get; set; } = null!;

    public virtual InstalacaoFederacao IdInstalacaoFederacaoRemNavigation { get; set; } = null!;

    public virtual OrgaoFederacao IdOrgaoFederacaoDestNavigation { get; set; } = null!;

    public virtual OrgaoFederacao IdOrgaoFederacaoRemNavigation { get; set; } = null!;

    public virtual ProtocoloFederacao IdProcedimentoFederacaoNavigation { get; set; } = null!;

    public virtual UnidadeFederacao IdUnidadeFederacaoDestNavigation { get; set; } = null!;

    public virtual UnidadeFederacao IdUnidadeFederacaoRemNavigation { get; set; } = null!;

    public virtual UsuarioFederacao? IdUsuarioFederacaoDestNavigation { get; set; }

    public virtual UsuarioFederacao? IdUsuarioFederacaoRemNavigation { get; set; }
}
