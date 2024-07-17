using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntContratosRecurso
{
    public int IdContrato { get; set; }

    public int IdRecurso { get; set; }

    public decimal? VlRecurso { get; set; }

    public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;

    public virtual TbCapRecurso IdRecursoNavigation { get; set; } = null!;
}
