using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbSegFormulariosComentario
{
    public int IdComentario { get; set; }

    public short IdForm { get; set; }

    public DateTime? DtComentario { get; set; }

    public string? DsLogin { get; set; }

    public string? DsComentario { get; set; }

    public string? DsResposta { get; set; }
}
