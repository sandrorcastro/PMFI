using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class LogBairro
{
    public int BaiNu { get; set; }

    public string BaiNo { get; set; } = null!;

    public string? BaiNome { get; set; }
}
