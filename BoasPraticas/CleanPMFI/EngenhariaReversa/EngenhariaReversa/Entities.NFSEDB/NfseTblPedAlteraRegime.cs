using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblPedAlteraRegime
    {
        public int Idpedido { get; set; }
        public int Idempresa { get; set; }
        public string Stobservacao { get; set; } = null!;
        public byte Idregime { get; set; }
        public DateTime Dtsolicitacao { get; set; }
        public DateTime? Dtparecer { get; set; }
        public string? Stparecer { get; set; }
        public string? Stfiscal { get; set; }
        public string Idusuario { get; set; } = null!;
        public string Stituacao { get; set; } = null!;

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblUsuario IdusuarioNavigation { get; set; } = null!;
    }
}
