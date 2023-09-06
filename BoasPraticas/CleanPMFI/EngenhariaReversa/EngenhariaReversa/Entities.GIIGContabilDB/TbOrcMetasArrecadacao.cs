using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcMetasArrecadacao
    {
        public int IdMeta { get; set; }
        public string? CdOrgao { get; set; }
        public int? IdTipo { get; set; }
        public int? IdOperacao { get; set; }
        public DateTime? DtLancamento { get; set; }
        public decimal? VlArrecadado { get; set; }
        public string? DsObservacao { get; set; }
        public short? NrMes { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtInclusao { get; set; }
        public short? IdEmpresa { get; set; }
    }
}
