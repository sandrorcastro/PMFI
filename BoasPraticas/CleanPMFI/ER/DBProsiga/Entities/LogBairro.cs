﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LogBairro
{
    public int BaiNu { get; set; }

    public string BaiNo { get; set; } = null!;

    public string? BaiNome { get; set; }
}
