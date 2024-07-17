using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AguaTiposServAgua
{
    public int TipoServId { get; set; }

    public string? TipoServNome { get; set; }

    public int? TipoServPrazoExecucao { get; set; }

    public string? TipoServLegislacao { get; set; }

    public virtual ICollection<AguaReqSolicServTipoServ> AguaReqSolicServTipoServs { get; set; } = new List<AguaReqSolicServTipoServ>();
}
