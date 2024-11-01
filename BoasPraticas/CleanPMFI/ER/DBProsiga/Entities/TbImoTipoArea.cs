﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbImoTipoArea
{
    public int IdtipoArea { get; set; }

    public string DsTipoArea { get; set; } = null!;

    public short CdTipoConta { get; set; }

    public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; } = new List<ImobensImovei>();
}
