using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbConSolicitacaoInscricaoCmcdespacho
{
    public long IdSolicitacaoInscricaoDespacho { get; set; }

    public long? IdSolicitacaoInscricao { get; set; }

    public DateTime? DtDespacho { get; set; }

    public string? DsLogin { get; set; }

    public string? DsDespacho { get; set; }

    public string? DsSituacao { get; set; }

    public virtual TbConSolicitacaoInscricaoCmc? IdSolicitacaoInscricaoNavigation { get; set; }
}
