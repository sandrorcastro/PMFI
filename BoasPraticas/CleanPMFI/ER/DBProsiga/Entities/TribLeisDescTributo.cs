﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribLeisDescTributo
{
    public long LeiDescId { get; set; }

    public int TipoTribId { get; set; }

    public short QtdeParcelas { get; set; }

    public decimal PercDescPrincipal { get; set; }

    public decimal PercDescJuros { get; set; }

    public decimal PercDescMulta { get; set; }

    public decimal PercDescCorrecao { get; set; }

    public decimal PercDescMultaDa { get; set; }

    /// <summary>
    /// Lei padrao caso nao seja informada nenhuma
    /// </summary>
    public string LeiDefault { get; set; } = null!;

    public virtual TribLeisDesc LeiDesc { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;

    public virtual ICollection<TribTipoDividum> TipoDivs { get; set; } = new List<TribTipoDividum>();
}
