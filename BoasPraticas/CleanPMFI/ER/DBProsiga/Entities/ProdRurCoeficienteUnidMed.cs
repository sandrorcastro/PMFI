﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ProdRurCoeficienteUnidMed
{
    public int IdcoeUni { get; set; }

    public int? IdprodRural { get; set; }

    public int? UnMedIdDe { get; set; }

    public int? UnMedIdPara { get; set; }

    public decimal? Coeficiente { get; set; }
}
