using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblErroSemMovimento
    {
        public int Iderro { get; set; }
        public int? Idempresa { get; set; }
        public short? Numes { get; set; }
        public short? Nuano { get; set; }
        public string? Stdescricao { get; set; }
        public string? Stsituacao { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
    }
}
