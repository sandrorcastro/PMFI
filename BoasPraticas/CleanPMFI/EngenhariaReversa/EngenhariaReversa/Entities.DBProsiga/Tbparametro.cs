using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbparametro
    {
        public string Nmparametro { get; set; } = null!;
        public string? Dsparametro { get; set; }
        public string? Dsvalor { get; set; }
        public string? Flvalores { get; set; }
        public string Fladmin { get; set; } = null!;
    }
}
