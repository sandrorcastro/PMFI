using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbDivTipoCredito
{
    public short IdTipoCredito { get; set; }

    public string? DsTipoCredito { get; set; }

    public bool? FlTributo { get; set; }

    public int? TrGrId { get; set; }

    public short? IdTipoNaturezaCredito { get; set; }

    public virtual TbDivTipoNaturezaCredito? IdTipoNaturezaCreditoNavigation { get; set; }

    public virtual TribTipoTributosGrupo? TrGr { get; set; }
}
