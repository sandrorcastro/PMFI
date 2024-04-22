﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeEscalaUnidadeSaude
{
    public int Idescala { get; set; }

    public int IdUnidadeSaude { get; set; }

    public int? NroAtendimentos { get; set; }

    public int? NroRetornos { get; set; }

    public virtual UnidadeSaude IdUnidadeSaudeNavigation { get; set; } = null!;

    public virtual SaudeEscala IdescalaNavigation { get; set; } = null!;
}
