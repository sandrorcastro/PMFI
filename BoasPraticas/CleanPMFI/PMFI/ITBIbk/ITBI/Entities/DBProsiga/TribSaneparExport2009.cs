﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribSaneparExport2009
{
    public long? EdificacaoId { get; set; }

    public string? InscricaoImobiliaria { get; set; }

    public string? SaneMatricula { get; set; }

    public int? TipoBxId { get; set; }

    public string? Proprietario { get; set; }

    public string? Endereco { get; set; }

    public decimal? Valor { get; set; }
}
