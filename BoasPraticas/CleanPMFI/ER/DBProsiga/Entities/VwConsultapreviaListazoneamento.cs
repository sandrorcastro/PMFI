﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwConsultapreviaListazoneamento
{
    public int QuadraId { get; set; }

    public int LogradId { get; set; }

    public short ZozoId { get; set; }

    public string? NomeZona { get; set; }

    public string? ZozoSigla { get; set; }
}
