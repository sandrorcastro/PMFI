﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAssinaturaTiposDocumento
    {
        public int IdDocumento { get; set; }
        public string? NmDocumento { get; set; }
        public string? VlIdentificador { get; set; }
    }
}
