﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class ControleVtAnttViewOperadorEmpresa
    {
        public string AcessoOperadorCpf { get; set; } = null!;
        public string? RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public string? Cpfcnpjempresa { get; set; }
        public long? ConId { get; set; }
    }
}
