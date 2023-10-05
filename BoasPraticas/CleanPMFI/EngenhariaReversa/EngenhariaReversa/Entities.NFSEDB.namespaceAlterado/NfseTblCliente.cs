using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblCliente
    {
        public int Idcliente { get; set; }
        public string Stnome { get; set; } = null!;
        public string Stcpfcnpj { get; set; } = null!;
        public string Sttipo { get; set; } = null!;
        public int Idcidade { get; set; }
        public string? Stcep { get; set; }
        public string? StenderecoLogr { get; set; }
        public string? StenderecoNumero { get; set; }
        public string? StenderecoComplemento { get; set; }
        public string? StenderecoBairro { get; set; }
        public string? Stim { get; set; }
        public string? Stemail { get; set; }
        public string? Sttelefone { get; set; }
        public string? Stsituacao { get; set; }
        public int Idempresa { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
    }
}
