using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblCnaeSubclasse
    {
        public NfseTblCnaeSubclasse()
        {
            NfseTblEmpresaCnaes = new HashSet<NfseTblEmpresaCnae>();
        }

        public string IdcnaeSubclasse { get; set; } = null!;
        public string? IdcnaeClasse { get; set; }
        public string? Stdescricao { get; set; }
        public string? Stativo { get; set; }

        public virtual ICollection<NfseTblEmpresaCnae> NfseTblEmpresaCnaes { get; set; }
    }
}
