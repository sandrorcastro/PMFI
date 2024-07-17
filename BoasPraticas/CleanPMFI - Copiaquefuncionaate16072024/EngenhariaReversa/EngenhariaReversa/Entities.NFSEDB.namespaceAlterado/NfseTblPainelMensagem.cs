using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblPainelMensagem
    {
        public int Idmensagem { get; set; }
        public string Sttitulo { get; set; } = null!;
        public string Stmensagem { get; set; } = null!;
        public DateTime? Dtinicial { get; set; }
        public DateTime? Dtfinal { get; set; }
        public string Stsituacao { get; set; } = null!;
        public int? Idempresa { get; set; }
    }
}
