using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoSemIncidencium
    {
        public int Iddeclaracao { get; set; }
        public int? Idempresa { get; set; }
        public short Numes { get; set; }
        public short Nuano { get; set; }
        public DateTime Dtdata { get; set; }
        public string? Idusuario { get; set; }
        public string Stsituacao { get; set; } = null!;
        public string? Stdeclaracao { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
        public virtual NfseTblUsuario? IdusuarioNavigation { get; set; }
    }
}
