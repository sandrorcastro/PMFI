using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinSaldosMensaisContasCorrente
    {
        public int IdSaldoBancario { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public short? NrMes { get; set; }
        public int? IdCc { get; set; }
        public decimal? VlSaldoBancario { get; set; }
        public decimal? VlAplicado { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbGerContasCorrente? IdCcNavigation { get; set; }
    }
}
