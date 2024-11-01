﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribRequerimentoRevisaoImovei
{
    public long ReqRevImoId { get; set; }

    public long? ReqRevId { get; set; }

    public long? EdificacaoId { get; set; }

    /// <summary>
    /// Em análise, Deferido ou Indeferido
    /// </summary>
    public string? ReqRevImoSituacao { get; set; }

    public string? ReqRevImoDescricao { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribRequerimentosRevisao? ReqRev { get; set; }
}
