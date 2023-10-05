using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblConfiguracao
    {
        public string Stcnpj { get; set; } = null!;
        public string? Stprefeitura { get; set; }
        public string? Stsecretaria { get; set; }
        public string? Stdepartamento { get; set; }
        public byte[]? Imlogo { get; set; }
        public int? Idcidade { get; set; }
        public string? Stcep { get; set; }
        public string? StenderecoLogr { get; set; }
        public string? StenderecoNumero { get; set; }
        public string? StenderecoComplemento { get; set; }
        public string? StenderecoBairro { get; set; }
        public string? Stemail { get; set; }
        public string? Sttelefone { get; set; }
        public string? Sthomepage { get; set; }
    }
}
