using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblLogDeclaracaoAuto
    {
        public int Idlogdecauto { get; set; }
        public DateTime Dthorainicial { get; set; }
        public DateTime Dthorafinal { get; set; }
        public string? Stmensagem { get; set; }
        public int Numescompetencia { get; set; }
        public int Nuanocompetencia { get; set; }
        public string? Sttiporecolhimento { get; set; }
        public string? Stsituacao { get; set; }
    }
}
