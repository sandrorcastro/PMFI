﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribUnificacao
    {
        public int IdUnificacao { get; set; }
        public int? IdOrigem { get; set; }
        public int? IdDestino { get; set; }
        public string? DsTabela { get; set; }
        public string? NmColunaUnificado { get; set; }
        public string? IdColunaUnificado { get; set; }
        public bool? FlUnificado { get; set; }
    }
}
