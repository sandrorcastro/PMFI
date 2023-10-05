using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DeclaracaoSemMovimentoBaixaPendente
    {
        public string? Prestador { get; set; }
        public short Mes { get; set; }
        public short Ano { get; set; }
        public string Declaracao { get; set; } = null!;
        public DateTime DtDeclaracao { get; set; }
        public long CodDivida { get; set; }
        public string? Baixa { get; set; }
    }
}
