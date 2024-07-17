using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaTributo
    {
        public int Idempresa { get; set; }
        public int Idtributo { get; set; }
        public decimal? Aliquota { get; set; }
    }
}
