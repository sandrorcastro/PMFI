﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class CombustivelSaidaMovimento
{
    public long CodCombMovSaida { get; set; }

    public string Motivo { get; set; } = null!;

    public string Situacao { get; set; } = null!;

    public DateTime Data { get; set; }

    public string UsuId { get; set; } = null!;

    public long ReqNum { get; set; }

    public virtual CombustivelSaidum ReqNumNavigation { get; set; } = null!;

    public virtual Usuario Usu { get; set; } = null!;
}
