using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class VwMegaDataNotasFiscai
    {
        public string? Stcpfcnpj { get; set; }
        public int? Ano { get; set; }
        public int? Mes { get; set; }
        public int? Numero { get; set; }
        public int Situacao { get; set; }
        public int Localtributacao { get; set; }
        public string? Servico116 { get; set; }
        public int Issretido { get; set; }
        public string? Basecalculo { get; set; }
        public string? Aliquota { get; set; }
        public string? Vlriss { get; set; }
        public string? Vlrissretido { get; set; }
        public string? Cmeprestador { get; set; }
        public string? Cpfcnpjtomador { get; set; }
        public string? Nometomador { get; set; }
        public int Tom { get; set; }
        public int Exigibilidade { get; set; }
        public string? Deducoes { get; set; }
        public string? Vlrservico { get; set; }
        public string? Cdverificacao { get; set; }
    }
}
