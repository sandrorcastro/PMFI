﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAlvaraConstrucaoDividasContrib
    {
        public long Numero { get; set; }
        public long ConIddivida { get; set; }

        public virtual TribDividasContribuinte ConIddividaNavigation { get; set; } = null!;
    }
}
