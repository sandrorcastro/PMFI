using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class VwDimEmpresaSimplesNacionalNfse
    {
        public int? Empresa { get; set; }
        public string? Cme { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Nome { get; set; }
    }
}
