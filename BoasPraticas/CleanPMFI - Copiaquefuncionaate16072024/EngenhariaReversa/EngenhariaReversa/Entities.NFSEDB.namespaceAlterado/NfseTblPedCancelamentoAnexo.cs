using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblPedCancelamentoAnexo
    {
        public int Idanexo { get; set; }
        public int Idcancelamento { get; set; }
        public byte[] Anexo { get; set; } = null!;
        public string Stnome { get; set; } = null!;
    }
}
