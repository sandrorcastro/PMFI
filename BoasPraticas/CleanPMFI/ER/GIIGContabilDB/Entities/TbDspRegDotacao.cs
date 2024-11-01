﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspRegDotacao
{
    public int IdRegistro { get; set; }

    public int IdDotacao { get; set; }

    public DateTime DtVinculacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
