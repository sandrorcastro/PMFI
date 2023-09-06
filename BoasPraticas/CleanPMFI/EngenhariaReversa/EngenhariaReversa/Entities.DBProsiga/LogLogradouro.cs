using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class LogLogradouro
    {
        public int LocNu { get; set; }
        public int? BaiNuIni { get; set; }
        public string TloTx { get; set; } = null!;
        public string LogNo { get; set; } = null!;
        public string Cep { get; set; } = null!;
        public string? LogradNome { get; set; }
    }
}
