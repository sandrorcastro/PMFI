﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbTipoOperacao
{
    public int IdTipoOperacao { get; set; }

    public string DsTipooperacao { get; set; } = null!;

    public int CdTribunal { get; set; }

    public virtual ICollection<TbDeprecicaoValorizacao> TbDeprecicaoValorizacaos { get; set; } = new List<TbDeprecicaoValorizacao>();
}
