using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcAlteracoesOrcExterna
{
    public int IdAlteracao { get; set; }

    public int? NrAtoAlteracao { get; set; }

    public string? NrAnoAtoAlteracao { get; set; }
}
