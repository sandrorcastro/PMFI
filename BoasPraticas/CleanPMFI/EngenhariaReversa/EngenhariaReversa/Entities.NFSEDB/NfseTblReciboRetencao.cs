using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblReciboRetencao
    {
        public int IdreciboRetencao { get; set; }
        public long Idnfse { get; set; }
        public DateTime Dtdataexpiracao { get; set; }
        public DateTime? Dtparecer { get; set; }
        public string Stsituacao { get; set; } = null!;
        public string? Idusuario { get; set; }
        public DateTime Dtdataemissao { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
        public virtual NfseTblUsuario? IdusuarioNavigation { get; set; }
    }
}
