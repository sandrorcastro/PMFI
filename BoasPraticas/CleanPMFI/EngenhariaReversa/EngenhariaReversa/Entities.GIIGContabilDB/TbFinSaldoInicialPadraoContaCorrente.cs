using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinSaldoInicialPadraoContaCorrente
    {
        public int IdSaldoInicial { get; set; }
        public short? IdEmpresa { get; set; }
        public int? IdPessoa { get; set; }
        public short? NrAno { get; set; }
        public string? CdContaContabil { get; set; }
        public DateTime? DtSaldoInicial { get; set; }
        public decimal? VlSaldoInicial { get; set; }
    }
}
