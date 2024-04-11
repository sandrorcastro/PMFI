using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcPrograma
{
    public short Idempresa { get; set; }

    public short NrAno { get; set; }

    public string CdPrograma { get; set; } = null!;

    public string? NmPrograma { get; set; }

    public string? DsPrograma { get; set; }

    public string? DsDetalhamento { get; set; }

    public DateTime? DtCadastro { get; set; }

    public int? IdPlaPrograma { get; set; }

    public int? IdPlaMovimento { get; set; }

    public bool? FlFinalistico { get; set; }

    public virtual TbGerEmpresasGoverno IdempresaNavigation { get; set; } = null!;

    public virtual ICollection<TbOrcProgramasAco> TbOrcProgramasAcos { get; set; } = new List<TbOrcProgramasAco>();
}
