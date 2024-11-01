﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscApreenso
{
    public int ApreId { get; set; }

    public short? ApreAno { get; set; }

    public int? VistId { get; set; }

    public string? ApreItens { get; set; }

    public string? ApreRazao { get; set; }

    public DateTime? ApreData { get; set; }

    public int? FiscalId { get; set; }

    public string? ApreDepositario { get; set; }

    public long LocalFisicoId { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public virtual TribFiscFiscai? Fiscal { get; set; }

    public virtual ICollection<TribFiscDevoluco> TribFiscDevolucos { get; set; } = new List<TribFiscDevoluco>();

    public virtual TribFiscVistoria? Vist { get; set; }
}
