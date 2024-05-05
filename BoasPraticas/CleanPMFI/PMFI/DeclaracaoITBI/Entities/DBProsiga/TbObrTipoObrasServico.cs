using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbObrTipoObrasServico
{
    public short IdtipoObraServ { get; set; }

    public string DsTipoObraServ { get; set; } = null!;

    public short? CdTipoObra { get; set; }

    public string DsDcadastroPrevioLoc { get; set; } = null!;

    public virtual ICollection<TbObrIntervencao> TbObrIntervencaos { get; set; } = new List<TbObrIntervencao>();
}
