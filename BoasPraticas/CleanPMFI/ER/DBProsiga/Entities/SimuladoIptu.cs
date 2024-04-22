﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SimuladoIptu
{
    public int? SimuId { get; set; }

    public long? EdificacaoId { get; set; }

    public string? Inscricaoimobiliaria { get; set; }

    public int? TipoTribId { get; set; }

    public int? TipoBxId { get; set; }

    public decimal? Valor { get; set; }

    public int? SimuAno { get; set; }

    public int? Incidencia { get; set; }

    public long? Edifedificacaoenglobamento { get; set; }
}