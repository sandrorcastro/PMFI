using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProgramasMovimentaco
{
    public int IdMovimentacao { get; set; }

    public int? IdPrograma { get; set; }

    public int? IdSituacao { get; set; }

    public string? DsDiretrizes { get; set; }

    public int? IdPublicoAlvo { get; set; }

    public int? IdFonte { get; set; }

    public int? IdPessoa { get; set; }

    public virtual TbPlaPrograma? IdProgramaNavigation { get; set; }
}
