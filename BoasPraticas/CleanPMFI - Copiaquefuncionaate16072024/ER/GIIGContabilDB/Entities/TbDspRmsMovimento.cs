using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRmsMovimento
{
    public int IdMovimento { get; set; }

    public int? IdRms { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? DsProcedimento { get; set; }

    public string? Ocorrencia { get; set; }

    public string? DsLogin { get; set; }

    public string? EnderecoIp { get; set; }

    public virtual TbDspRm? IdRmsNavigation { get; set; }
}
