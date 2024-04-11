using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRegistrosNecLicitOrgaosItensAlteraco
{
    public int IdRegistroAlteracao { get; set; }

    public int? IdRegistroOrgaoCedente { get; set; }

    public int? IdRegistroOrgaoRecebedor { get; set; }

    public int? IdItem { get; set; }

    public int? NrQuantidade { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
