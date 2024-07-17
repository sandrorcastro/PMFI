using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblMalaDiretaEnvio
    {
        public int Idmaladiretaenvio { get; set; }
        public int Idmaladireta { get; set; }
        public int Idempresa { get; set; }
        public string Stemailempresa { get; set; } = null!;
        public string Idusuario { get; set; } = null!;
        public DateTime Dtenvio { get; set; }
    }
}
