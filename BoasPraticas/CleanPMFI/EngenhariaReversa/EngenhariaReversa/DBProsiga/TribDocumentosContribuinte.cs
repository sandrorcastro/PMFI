﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDocumentosContribuinte
    {
        public int IdDocumento { get; set; }
        public long? ConId { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string? NrDocumento { get; set; }
        public string? DsUf { get; set; }
    }
}
