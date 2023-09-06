using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbcidade
    {
        public int Idcidade { get; set; }
        public string Nmcidade { get; set; } = null!;
        public int? Idpais { get; set; }
        public string? Dssiglauf { get; set; }
        public string? Cdibgecodigo { get; set; }
        public string? Fzfonetizado { get; set; }
    }
}
