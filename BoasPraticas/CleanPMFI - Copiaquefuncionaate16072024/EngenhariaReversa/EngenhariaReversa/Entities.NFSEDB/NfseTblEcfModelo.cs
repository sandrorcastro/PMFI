using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEcfModelo
    {
        public int Idmodelo { get; set; }
        public int Idmarca { get; set; }
        public string Stmodelo { get; set; } = null!;

        public virtual NfseTblEcfMarca IdmarcaNavigation { get; set; } = null!;
    }
}
