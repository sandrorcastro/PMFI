﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribZona
    {
        public TribZona()
        {
            TribZonaZoneamentos = new HashSet<TribZonaZoneamento>();
        }

        public short ZonaId { get; set; }
        public string? ZonaDescricao { get; set; }

        public virtual ICollection<TribZonaZoneamento> TribZonaZoneamentos { get; set; }
    }
}
