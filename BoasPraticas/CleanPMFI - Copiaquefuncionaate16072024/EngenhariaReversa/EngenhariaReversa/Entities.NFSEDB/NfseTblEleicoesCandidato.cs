using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEleicoesCandidato
    {
        public int Id { get; set; }
        public string Cnpj { get; set; } = null!;
        public string Nome { get; set; } = null!;
    }
}
