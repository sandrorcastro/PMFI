using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinSaldoInicialContaDeposito
    {
        public int IdSaldoContaDeposito { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdPessoa { get; set; }
        public short? NrAno { get; set; }
        public int? IdContaContabil { get; set; }
        public decimal? VlSaldoInicial { get; set; }
    }
}
