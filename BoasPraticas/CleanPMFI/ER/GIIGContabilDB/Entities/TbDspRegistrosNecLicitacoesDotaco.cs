using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRegistrosNecLicitacoesDotaco
{
    public int IdRegistro { get; set; }

    public int IdDotacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? IdRecurso { get; set; }

    public int? IdNatDespesa { get; set; }

    public virtual TbDspRegistrosNecessidadeLicitaco IdRegistroNavigation { get; set; } = null!;
}
