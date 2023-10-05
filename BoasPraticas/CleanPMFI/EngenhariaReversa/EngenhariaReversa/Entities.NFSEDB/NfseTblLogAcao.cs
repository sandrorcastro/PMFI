using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblLogAcao
    {
        public int Idlogacao { get; set; }
        public int Idlogacaotipo { get; set; }
        public string Idusuario { get; set; } = null!;
        public int? Idempresa { get; set; }
        public string Stlog { get; set; } = null!;
        public DateTime Dtdata { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
        public virtual NfseTblLogAcaoTipo IdlogacaotipoNavigation { get; set; } = null!;
        public virtual NfseTblUsuario IdusuarioNavigation { get; set; } = null!;
    }
}
