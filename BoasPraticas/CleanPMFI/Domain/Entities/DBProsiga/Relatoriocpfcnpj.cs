﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Relatoriocpfcnpj
    {
        public string? Pessoa { get; set; }
        public string? Nis { get; set; }
        public string? Cpf { get; set; }
        public string? Identidade { get; set; }
        public int? Ordem { get; set; }
    }
}
