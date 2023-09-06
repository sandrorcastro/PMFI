using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinSaldosMensaisContasContabei
    {
        public int IdSaldoContaContabil { get; set; }
        public int? IdContaContabil { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? NrMes { get; set; }
        public decimal? VlSaldoInicial { get; set; }
        public decimal? VlCreditos { get; set; }
        public decimal? VlCreditosSemEstornos { get; set; }
        public decimal? VlDebitos { get; set; }
        public decimal? VlDebitosSemEstornos { get; set; }
    }
}
