using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblHomologacao
    {
        public int Idhomologacao { get; set; }
        public int Idempresa { get; set; }
        public string Stsituacao { get; set; } = null!;
        public DateTime Dtdata { get; set; }
        public DateTime? Dtdatahomologacao { get; set; }
        public string? Stmotivo { get; set; }
        public DateTime? Dtliberacaoacesso { get; set; }
        public string? Idusuario { get; set; }
        public bool? Isrecad { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
    }
}
