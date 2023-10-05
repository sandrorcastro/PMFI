using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblContaNota
    {
        public int Idconta { get; set; }
        public long Idnfse { get; set; }
        public long? IdnfseSubstituta { get; set; }
        /// <summary>
        /// C=Canelada; S=Substituída; N=Normal
        /// </summary>
        public string Stsituacao { get; set; } = null!;

        public virtual NfseTblContum IdcontaNavigation { get; set; } = null!;
        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
    }
}
