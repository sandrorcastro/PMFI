using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCtiResposta
{
    public int IdResposta { get; set; }

    public int IdPergunta { get; set; }

    public int IdServidor { get; set; }

    public string? DsResposta { get; set; }

    public DateTime? DtResposta { get; set; }

    public virtual TbCtiPergunta IdPerguntaNavigation { get; set; } = null!;
}
