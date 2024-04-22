﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class DiaSemana
    {
        public DiaSemana()
        {
            IdEscalas = new HashSet<SaudeEscala>();
        }

        public int IdDiaSemana { get; set; }
        public string? DiaSemana1 { get; set; }

        public virtual ICollection<SaudeEscala> IdEscalas { get; set; }
    }
}