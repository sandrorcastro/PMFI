﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TiposDocumentosOficiai
    {
        public TiposDocumentosOficiai()
        {
            ParametroAssinaturas = new HashSet<ParametroAssinatura>();
        }

        public long IdtipoDoc { get; set; }
        public string? NomeDoc { get; set; }

        public virtual ICollection<ParametroAssinatura> ParametroAssinaturas { get; set; }
    }
}
