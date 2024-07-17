using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblCep
    {
        public int Idcep { get; set; }
        public string Stcep { get; set; } = null!;
        public string? Stbairro { get; set; }
        public string? Stcidade { get; set; }
        public string? Stlogradourocompleto { get; set; }
        public string? Stlogradouro { get; set; }
        public string? Sttipologradouro { get; set; }
        public string? Stcomplemento { get; set; }
        public int? Idcidade { get; set; }
    }
}
