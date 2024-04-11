using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspEmpenhoEmailEnviado
{
    public int IdNotificacao { get; set; }

    public int? IdEmpenho { get; set; }

    public DateTime? DtInclusao { get; set; }
}
