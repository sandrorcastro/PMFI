using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifIdentificacaoDependencium
    {
        public int Iddependencia { get; set; }
        public int Iddeclaracao { get; set; }
        public string Stcoddepende { get; set; } = null!;
        public byte Nuindinscmun { get; set; }
        public string? Stcnpjproprio { get; set; }
        public byte Nutipodepende { get; set; }
        public string? Stenddepende { get; set; }
        public string Stcnpjunificado { get; set; } = null!;
        public int Idcidade { get; set; }
        public string? Stcontabpropia { get; set; }
        public DateTime? Dtiniparaliza { get; set; }
        public DateTime? Dtfimparaliza { get; set; }
    }
}
