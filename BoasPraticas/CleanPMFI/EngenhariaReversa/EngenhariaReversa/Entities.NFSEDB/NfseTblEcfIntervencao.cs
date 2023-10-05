using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEcfIntervencao
    {
        public int Idecfint { get; set; }
        public int Idempresa { get; set; }
        public int? Idempresacred { get; set; }
        public int Idmotinterven { get; set; }
        public DateTime Dtemissao { get; set; }
        public int Nuordemseque { get; set; }
        public int Idtipomodelo { get; set; }
        public int Idversoftbasico { get; set; }
        public string Nufabricacao { get; set; } = null!;
        public string Nuserie { get; set; } = null!;
        public int? Nucooantes { get; set; }
        public int? Nucooapos { get; set; }
        public int? Nucroantes { get; set; }
        public int? Nucroapos { get; set; }
        public int? Nucrzantes { get; set; }
        public int? Nucrzapos { get; set; }
        public int? Nutotalgeraantes { get; set; }
        public int? Nutotalgeraapos { get; set; }
        public string? Stobservacoes { get; set; }
        public string Stsituacao { get; set; } = null!;
    }
}
