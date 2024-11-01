﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicNaturezasProcedimento
{
    public short IdModalidade { get; set; }

    public short IdNaturezaProcedimento { get; set; }

    public string? DsNaturezaProcedimento { get; set; }

    public string? FlPadroTce { get; set; }

    public string? FlDesclassificaAutomatico { get; set; }

    public virtual TbLicModalidade IdModalidadeNavigation { get; set; } = null!;

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();
}
