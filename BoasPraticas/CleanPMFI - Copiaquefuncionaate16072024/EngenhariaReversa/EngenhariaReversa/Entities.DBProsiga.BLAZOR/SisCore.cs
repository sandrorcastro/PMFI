﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SisCore
    {
        public SisCore()
        {
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
        }

        public int SicoId { get; set; }
        public string? SicoNome { get; set; }

        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
    }
}
