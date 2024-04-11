using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCapRecursosOrgaoUnidade
{
    public int IdRecursoOrgao { get; set; }

    public int IdRecurso { get; set; }

    public string? CdOrgao { get; set; }

    public string? NmOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string? NmUnidade { get; set; }

    public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
}
