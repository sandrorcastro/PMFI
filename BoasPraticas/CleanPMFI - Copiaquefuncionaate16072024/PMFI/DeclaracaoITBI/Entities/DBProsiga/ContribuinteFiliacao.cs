using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ContribuinteFiliacao
{
    public long ConFilId { get; set; }

    public long? ConId { get; set; }

    public long? ConIdfiliacao { get; set; }

    public string? ConFilNome { get; set; }

    public string? ConFilTipo { get; set; }

    public DateTime? ConFilDtInclusao { get; set; }

    public DateTime? ConFilDtFim { get; set; }

    public string? ConFilUsuarioInclusao { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual Contribuinte? ConIdfiliacaoNavigation { get; set; }
}
