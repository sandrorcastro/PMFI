using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbPlaProjetosAtividade
{
    public int IdProjetoAtividade { get; set; }

    public short? IdVersaoCriacao { get; set; }

    public short? NrAno { get; set; }

    public string? CdProjetoAtividade { get; set; }

    public string? DsProjetoAtividade { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
