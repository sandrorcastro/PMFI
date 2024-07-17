using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPpaProgramasPermissoesOrgao
{
    public int IdPermisao { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAnoPpa { get; set; }

    public short? NrVersao { get; set; }

    public string? CdPrograma { get; set; }

    public string? CdOrgao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbPpaPrograma? TbPpaPrograma { get; set; }
}
