﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class EdutipoLocal
{
    public long TipoLocId { get; set; }

    public string? TipoLocNome { get; set; }

    public virtual ICollection<Localizacao> Localizacaos { get; set; } = new List<Localizacao>();
}
