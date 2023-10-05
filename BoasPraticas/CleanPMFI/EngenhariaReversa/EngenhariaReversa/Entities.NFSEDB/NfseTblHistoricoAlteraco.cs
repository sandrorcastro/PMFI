using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblHistoricoAlteraco
    {
        public int Idhistoricoalteracao { get; set; }
        public string Sttabela { get; set; } = null!;
        public string Idregistro { get; set; } = null!;
        public DateTime Dtdata { get; set; }
        public string Sttipo { get; set; } = null!;
        public string Stusuario { get; set; } = null!;
        public string Stparecer { get; set; } = null!;
        public string? Nuprotocolo { get; set; }
        public DateTime? Dtprotocolizacao { get; set; }
        public string? Stmetadadoregistrobefore { get; set; }
        public string? Stmetadadoregistroafter { get; set; }
    }
}
