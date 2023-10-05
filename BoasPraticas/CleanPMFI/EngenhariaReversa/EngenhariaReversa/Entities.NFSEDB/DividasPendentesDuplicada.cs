using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DividasPendentesDuplicada
    {
        public long DivEmpId { get; set; }
        public long EmprCmc { get; set; }
        public int? EmprDivMes { get; set; }
        public int? EmprDivAno { get; set; }
        public int? TipoTribId { get; set; }
        public decimal EmprDivValor { get; set; }
        public string? TipoBxNome { get; set; }
        public string? ConCnpjcpf { get; set; }
        public string? ConNome { get; set; }
    }
}
