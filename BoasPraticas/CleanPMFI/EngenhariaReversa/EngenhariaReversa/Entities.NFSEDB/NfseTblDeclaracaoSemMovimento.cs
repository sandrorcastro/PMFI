using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblDeclaracaoSemMovimento
    {
        public int Iddeclaracao { get; set; }
        public int Idempresa { get; set; }
        public short Numes { get; set; }
        public short Nuano { get; set; }
        public DateTime Dtdata { get; set; }
        public string Stdeclaracao { get; set; } = null!;
        public string Idusuario { get; set; } = null!;
        public string Stsituacao { get; set; } = null!;
        public int? Idtipodeclaracao { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblTipoDeclaracao? IdtipodeclaracaoNavigation { get; set; }
        public virtual NfseTblUsuario IdusuarioNavigation { get; set; } = null!;
    }
}
