﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Profissao
    {
        public string IdProfissao { get; set; } = null!;
        public string? SgProfissao { get; set; }
        public string? DsProfissao { get; set; }
    }
}
