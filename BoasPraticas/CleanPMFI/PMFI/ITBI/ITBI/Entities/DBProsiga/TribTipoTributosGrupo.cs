using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribTipoTributosGrupo
{
    public int TrGrId { get; set; }

    public string? TrGrDescricao { get; set; }

    public bool? TrGrGeraCreditoInscricao { get; set; }

    public bool? TrGrGeraLctoCreditoInscricao { get; set; }

    public virtual ICollection<TbDivTipoCredito> TbDivTipoCreditos { get; set; } = new List<TbDivTipoCredito>();

    public virtual ICollection<TribTipoTributo> TribTipoTributos { get; set; } = new List<TribTipoTributo>();
}
