using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinNumeracoesBalancetesContabil
    {
        public int IdLanctoNumerado { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public int? NrLancamento { get; set; }
        public DateTime? DtLancamento { get; set; }
        public decimal? VlLancamento { get; set; }
        public int? IdLancamento { get; set; }
        public string? TpLancamento { get; set; }
        public int? IdContaContabil { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdCc { get; set; }
        public long? IdObjeto { get; set; }
        public string? CdOrgaoSaldo { get; set; }
        public string? CdUnidadeSaldo { get; set; }
    }
}
