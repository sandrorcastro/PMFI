using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblPedSubstituicao
    {
        public int Idnupedsubs { get; set; }
        public long Idnfse { get; set; }
        public string Idusuario { get; set; } = null!;
        public DateTime Dthorasolicitacao { get; set; }
        public DateTime? Dthoraconfirmacao { get; set; }
        /// <summary>
        /// Id do usuário no administrativo que efetuou a liberação
        /// </summary>
        public string? Idusuarioconfirmou { get; set; }
        public string Stsituacao { get; set; } = null!;
        public string? Stobsavaliacao { get; set; }

        public virtual NfseTblNfse IdnfseNavigation { get; set; } = null!;
        public virtual NfseTblUsuario IdusuarioNavigation { get; set; } = null!;
    }
}
