﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Tbprocuracaoeletronica
    {
        public int Idprocuracaoeletronica { get; set; }
        public int? Idusuario { get; set; }
        public int? Idusuarioautorizado { get; set; }
        public DateTime Dtconcessao { get; set; }
        public DateTime? Dtrevogacao { get; set; }
    }
}
