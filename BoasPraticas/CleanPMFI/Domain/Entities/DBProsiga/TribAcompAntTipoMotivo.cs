﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAcompAntTipoMotivo
    {
        public TribAcompAntTipoMotivo()
        {
            TribAcompAnteriors = new HashSet<TribAcompAnterior>();
        }

        public int AcoTipoId { get; set; }
        public string? AcoTipoDescricao { get; set; }

        public virtual ICollection<TribAcompAnterior> TribAcompAnteriors { get; set; }
    }
}
