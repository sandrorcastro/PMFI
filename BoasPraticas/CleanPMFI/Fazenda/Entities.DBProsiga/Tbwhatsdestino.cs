﻿using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbwhatsdestino
{
    public int Id { get; set; }

    public string Nrtelefone { get; set; } = null!;

    public string? Flativo { get; set; }
}
