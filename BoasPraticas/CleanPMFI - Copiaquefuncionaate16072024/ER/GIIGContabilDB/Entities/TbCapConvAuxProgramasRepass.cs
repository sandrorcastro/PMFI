using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapConvAuxProgramasRepass
{
    public int IdRepasse { get; set; }

    public int IdRecurso { get; set; }

    public string CdOrgao { get; set; } = null!;

    public string CdUnidade { get; set; } = null!;

    public short NrMes { get; set; }

    public short NrAno { get; set; }

    public decimal? VlRepassado { get; set; }

    public short? NrProcesso { get; set; }

    public DateTime? DtProcesso { get; set; }

    public string? NmEntidade { get; set; }

    public string? CpfCnpjEntidade { get; set; }

    public string? NmResponsavel { get; set; }

    public string? CpfResponsavel { get; set; }

    public virtual TbCapConvAuxPrograma IdRecursoNavigation { get; set; } = null!;
}
