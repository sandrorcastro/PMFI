﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribCartaHabitacaoAlvaraConstr
    {
        public long Idcarta { get; set; }
        public long Numero { get; set; }

        public virtual TribCartaHabitacao IdcartaNavigation { get; set; } = null!;
    }
}
