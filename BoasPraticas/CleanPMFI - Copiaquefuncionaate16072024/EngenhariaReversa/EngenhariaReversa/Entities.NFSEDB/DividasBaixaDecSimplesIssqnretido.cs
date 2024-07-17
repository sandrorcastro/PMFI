using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DividasBaixaDecSimplesIssqnretido
    {
        public string? PrestadorCnpj { get; set; }
        public string? PrestadorNome { get; set; }
        public string? TomadorCpfCnpj { get; set; }
        public string? TomadorNome { get; set; }
        public int? NotaNumero { get; set; }
        public int EncerramentoCod { get; set; }
        public int DeclaracaoCod { get; set; }
        public long DividaCod { get; set; }
        public decimal DividaValor { get; set; }
    }
}
