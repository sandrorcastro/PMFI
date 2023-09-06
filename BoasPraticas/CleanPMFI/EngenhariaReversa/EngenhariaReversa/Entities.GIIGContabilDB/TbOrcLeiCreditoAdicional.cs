using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcLeiCreditoAdicional
    {
        public int IdLeiCreditoAdicional { get; set; }
        public int? IdLei { get; set; }
        public short IdTipoCreditoAdicional { get; set; }
        public short IdTipoRecurso { get; set; }
        public decimal? VlAutorizado { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
    }
}
