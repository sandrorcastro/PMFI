﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AssinaturasComposicao
    {
        public int Sequencia { get; set; }
        public long IdparamAssinatura { get; set; }
        public string Nome { get; set; } = null!;
        public string? Cargo { get; set; }

        public virtual ParametroAssinatura IdparamAssinaturaNavigation { get; set; } = null!;
    }
}
