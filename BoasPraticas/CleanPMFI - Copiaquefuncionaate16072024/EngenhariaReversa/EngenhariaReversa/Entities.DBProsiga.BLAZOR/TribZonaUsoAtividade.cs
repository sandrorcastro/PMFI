﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZonaUsoAtividade
    {
        public short ZousId { get; set; }
        public string Atividade { get; set; } = null!;
        public short ZotlId { get; set; }

        public virtual TribZonaTipoLiberacao Zotl { get; set; } = null!;
    }
}
