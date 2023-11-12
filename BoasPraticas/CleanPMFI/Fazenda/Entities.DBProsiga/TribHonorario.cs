﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribHonorario
{
    public int HonorarioId { get; set; }

    public string? HonoNumeroAutos { get; set; }

    public string? HonoExecutado { get; set; }

    public decimal? HonoPercentual { get; set; }

    public DateTime? HonoDataBase { get; set; }
}
