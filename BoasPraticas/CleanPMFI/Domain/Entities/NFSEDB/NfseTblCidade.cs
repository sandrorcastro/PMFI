using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblCidade
    {
        public NfseTblCidade()
        {
            NfseTblEmpresaContratos = new HashSet<NfseTblEmpresaContrato>();
        }

        public int Idcidade { get; set; }
        public string? Stnome { get; set; }
        public string? Stuf { get; set; }
        public int? Stcodigoibge { get; set; }

        public virtual ICollection<NfseTblEmpresaContrato> NfseTblEmpresaContratos { get; set; }
    }
}
