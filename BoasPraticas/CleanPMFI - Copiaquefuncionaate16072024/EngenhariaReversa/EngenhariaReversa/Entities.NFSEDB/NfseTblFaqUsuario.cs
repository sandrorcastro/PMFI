using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblFaqUsuario
    {
        public int Id { get; set; }
        public string Usuario { get; set; } = null!;
        public string Senha { get; set; } = null!;
        public int Idcontribuinte { get; set; }
        public string Isadmin { get; set; } = null!;
    }
}
