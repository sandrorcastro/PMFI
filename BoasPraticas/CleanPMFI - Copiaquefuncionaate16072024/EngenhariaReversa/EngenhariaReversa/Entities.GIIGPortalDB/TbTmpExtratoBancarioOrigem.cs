using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpExtratoBancarioOrigem
    {
        public string? Agencia { get; set; }
        public string? Banco { get; set; }
        public string? Conta { get; set; }
        public DateTime? Data { get; set; }
        public decimal Valor { get; set; }
        public string? TipoLancamento { get; set; }
        public decimal? SaldoContabil { get; set; }
        public decimal? SaldoExtrato { get; set; }
    }
}
