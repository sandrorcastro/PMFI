using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DividasTemp
    {
        public int Iddivida { get; set; }
        public string Razaosocial { get; set; } = null!;
        public string Cnpj { get; set; } = null!;
        public string Cmc { get; set; } = null!;
        public decimal Valor { get; set; }
        public int Idtributo { get; set; }
        public string Nometributo { get; set; } = null!;
        public int Idbaixa { get; set; }
        public string Nomebaixa { get; set; } = null!;
        public int Mes { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
