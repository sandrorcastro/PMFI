using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblHomologacaoTomador
    {
        public int IdhomologaTom { get; set; }
        public int Idcontribuinte { get; set; }
        public DateTime Dtdatasoli { get; set; }
        public DateTime? Dtdatahomologacao { get; set; }
        public string Stsituacao { get; set; } = null!;
        public string? Stmotivo { get; set; }
        public string? Idusuario { get; set; }

        public virtual NfseTblContribuinte IdcontribuinteNavigation { get; set; } = null!;
    }
}
