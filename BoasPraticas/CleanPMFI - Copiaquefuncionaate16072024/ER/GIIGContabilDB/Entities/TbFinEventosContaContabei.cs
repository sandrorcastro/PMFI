using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinEventosContaContabei
{
    public int IdEventoContaContabil { get; set; }

    public short NrExercicio { get; set; }

    public short? IdEmpresa { get; set; }

    public int CdEvento { get; set; }

    public short? NrSequencia { get; set; }

    public string? CdContaContabil { get; set; }

    public string? TpNaturezaSaldo { get; set; }

    public short? IdTipoMovimento { get; set; }

    public short? IdTipoFinanceiroPatrimonial { get; set; }

    public short? IdTipoVariacao { get; set; }
}
