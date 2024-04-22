﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class RecursoFinanceiro
    {
        public RecursoFinanceiro()
        {
            Acessorios = new HashSet<Acessorio>();
        }

        public int RecursoId { get; set; }
        public string? RecursoNome { get; set; }

        public virtual ICollection<Acessorio> Acessorios { get; set; }
    }
}
