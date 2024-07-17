using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaServicoDeducao
    {
        public int Idempresa { get; set; }
        public string Idservico { get; set; } = null!;
        public string Stmotivo { get; set; } = null!;
        public byte[]? Binarquivo { get; set; }
        public string? Stnomearquivo { get; set; }
        public string? Sttipoarquivo { get; set; }
        public DateTime Dtdata { get; set; }
        public string Idusuario { get; set; } = null!;
        public string Stsituacao { get; set; } = null!;

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
