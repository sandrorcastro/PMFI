﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SeriTurInformacoesPrestada
    {
        public long IdmovInform { get; set; }
        public long? IdmovOrigem { get; set; }
        public long? Qtde { get; set; }
        public long? IdtipoInfo { get; set; }
    }
}
