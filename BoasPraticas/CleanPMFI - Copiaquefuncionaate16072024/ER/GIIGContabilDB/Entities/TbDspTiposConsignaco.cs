using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspTiposConsignaco
{
    public short IdTipoConsignacao { get; set; }

    public short? IdEmpresa { get; set; }

    public string? NmTipoConsignacao { get; set; }

    public string? CdContaContabil { get; set; }

    public int? IdRecurso { get; set; }

    public int? IdPessoa { get; set; }

    public decimal? NrPercentual { get; set; }

    public string? DsCategoria { get; set; }

    public int? IdCcfavorecido { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public DateTime? DtTermino { get; set; }

    public int? IdTitularContaCorrente { get; set; }

    public string? FlExecutaBaixaAutomatica { get; set; }

    public string? FlRepercuteGuia { get; set; }

    public DateTime? DtInicio { get; set; }

    public int? IdTipoOrigem { get; set; }

    public virtual ICollection<TbDspConsignaco> TbDspConsignacos { get; set; } = new List<TbDspConsignaco>();
}
