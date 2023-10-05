using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaContratosAnexo
    {
        public int Idempconanexo { get; set; }
        public int Idempcont { get; set; }
        public string? Stdescricao { get; set; }
        public byte[] Binarquivo { get; set; } = null!;
        public string? Stextensao { get; set; }
        public DateTime Dtanexo { get; set; }

        public virtual NfseTblEmpresaContrato IdempcontNavigation { get; set; } = null!;
    }
}
