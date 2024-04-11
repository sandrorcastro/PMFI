using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecReceitasContaContabil
{
    public short IdReceitaContaContabil { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public string? CdReceita { get; set; }

    public string? CdContaContabil { get; set; }

    public string? CdContaContabilDisponivel { get; set; }

    public int? IdRecurso { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? DsTipo { get; set; }

    public int? IdTipoDoctoFinanceiro { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public short? IdTipoConsignacao { get; set; }

    public string? TpEntrada { get; set; }

    public string? CdContaContabilReceita { get; set; }
}
