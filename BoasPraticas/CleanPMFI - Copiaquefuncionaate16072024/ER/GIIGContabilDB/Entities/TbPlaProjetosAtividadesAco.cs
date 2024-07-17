using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProjetosAtividadesAco
{
    public int IdProjetoAtividade { get; set; }

    public int IdAcao { get; set; }

    public int IdVersaoVinculo { get; set; }

    public DateTime? DtVinculo { get; set; }

    public string? DsLoginVinculo { get; set; }

    public int? IdVersaoCancelamento { get; set; }

    public DateTime? DtCancelamento { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public string? DsLoginCancelamento { get; set; }

    public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;

    public virtual TbPlaProjetosAtividade IdProjetoAtividadeNavigation { get; set; } = null!;
}
