﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribSaneparDivida
{
    public long SaneDividaId { get; set; }

    public long? SaneDetId { get; set; }

    public long? ImoIddivida { get; set; }

    public virtual TribSaneparArquivoBaixaDetalhe? SaneDet { get; set; }
}
