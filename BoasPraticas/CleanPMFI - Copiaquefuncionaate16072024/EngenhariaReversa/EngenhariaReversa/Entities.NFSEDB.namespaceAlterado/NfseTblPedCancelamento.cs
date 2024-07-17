using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblPedCancelamento
    {
        public int Idcancelamento { get; set; }
        public long Idnfse { get; set; }
        public string Idusuario { get; set; } = null!;
        public DateTime Dthorasolicitacao { get; set; }
        public string Stsituacao { get; set; } = null!;
        public int Idmotcan { get; set; }
        public string Stdescmotcan { get; set; } = null!;
        public long? Idnfseref { get; set; }
        public DateTime? Dthoraconfirmacao { get; set; }
        public string? Stobsavaliacao { get; set; }
        public string? Idusuarioavaliou { get; set; }

        public virtual NfseTblMotivoCancelamento IdmotcanNavigation { get; set; } = null!;
        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
        public virtual NfseTblUsuario IdusuarioNavigation { get; set; } = null!;
    }
}
