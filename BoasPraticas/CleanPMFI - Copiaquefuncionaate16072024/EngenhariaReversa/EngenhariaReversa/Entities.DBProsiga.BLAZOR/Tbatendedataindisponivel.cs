﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Tbatendedataindisponivel
    {
        public int Iddataindisponivel { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan? Horainicial { get; set; }
        public TimeSpan? Horafinal { get; set; }
        public bool? Diainteiro { get; set; }
        public int Idservico { get; set; }
    }
}
