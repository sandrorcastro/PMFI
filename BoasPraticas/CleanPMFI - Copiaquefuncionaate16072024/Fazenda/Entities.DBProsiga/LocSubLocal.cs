using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class LocSubLocal
{
    public int SubLocalId { get; set; }

    public int? SubLocLocalId { get; set; }

    public string? SubLocNome { get; set; }

    public string? SubLocFone { get; set; }

    public int? SubLocTipo { get; set; }

    public string? SubLocRespMatricula { get; set; }

    public string? SubLocRespNome { get; set; }

    public string? SubLocRespRg { get; set; }

    public string? SubLocTecUltAlt { get; set; }

    public DateTime? SubLocDtUltAlt { get; set; }

    public virtual ICollection<LocTaxa> LocTaxas { get; set; } = new List<LocTaxa>();

    public virtual Localizacao? SubLocLocal { get; set; }

    public virtual LocTpSubLocal? SubLocTipoNavigation { get; set; }
}
