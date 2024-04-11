using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProgramasPermissoesOrgao
{
    public int IdPermissao { get; set; }

    public int? IdPrograma { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public virtual TbPlaPrograma? IdProgramaNavigation { get; set; }
}
