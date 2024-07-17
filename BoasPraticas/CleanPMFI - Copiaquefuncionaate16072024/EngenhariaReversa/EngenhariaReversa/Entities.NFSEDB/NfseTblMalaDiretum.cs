using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblMalaDiretum
    {
        public int Idmaladireta { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string Idusuario { get; set; } = null!;
        public DateTime Dtinclusao { get; set; }
        public int Idtexto { get; set; }
    }
}
