﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEdifCartoriosCompradore
{
    public int IdcartorioComprador { get; set; }

    public int? IdedifCartorio { get; set; }

    public long? ConId { get; set; }

    public string? DsCpfcnpj { get; set; }

    public string? DsNome { get; set; }
}
