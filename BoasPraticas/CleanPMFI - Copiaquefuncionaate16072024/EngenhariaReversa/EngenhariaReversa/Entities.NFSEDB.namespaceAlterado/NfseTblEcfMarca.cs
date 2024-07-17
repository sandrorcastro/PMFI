using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEcfMarca
    {
        public NfseTblEcfMarca()
        {
            NfseTblEcfModelos = new HashSet<NfseTblEcfModelo>();
        }

        public int Idmarca { get; set; }
        public string Stmarca { get; set; } = null!;

        public virtual ICollection<NfseTblEcfModelo> NfseTblEcfModelos { get; set; }
    }
}
