using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAlvaraConstrucaoProfissional
{
    public long IdalvaraProf { get; set; }

    public long? Numero { get; set; }

    public long? IdcontribCategProf { get; set; }

    public DateTime? DataCad { get; set; }

    public string? Artnum { get; set; }

    public DateTime? Artdata { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtPrevTermino { get; set; }

    public virtual TribContribCategProf? IdcontribCategProfNavigation { get; set; }
}
