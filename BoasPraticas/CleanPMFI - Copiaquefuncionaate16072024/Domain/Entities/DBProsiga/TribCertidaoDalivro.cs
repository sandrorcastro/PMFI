using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCertidaoDalivro
    {
        public long IdCertidaoLivro { get; set; }
        public long? CertidaoDaid { get; set; }
        public long? LivroDaid { get; set; }

        public virtual TribCertidaoDum? CertidaoDa { get; set; }
        public virtual TribLivroDividaAtiva? LivroDa { get; set; }
    }
}
