using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ControleUnidade
{
    public long IdControleUnidade { get; set; }

    public long IdProcedimento { get; set; }

    public int IdSituacao { get; set; }

    public DateTime DthSnapshot { get; set; }

    public int IdUsuario { get; set; }

    public DateTime DthExecucao { get; set; }
}
