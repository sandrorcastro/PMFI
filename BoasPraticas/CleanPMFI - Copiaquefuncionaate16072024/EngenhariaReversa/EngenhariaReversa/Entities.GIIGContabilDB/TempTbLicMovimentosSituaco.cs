using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbLicMovimentosSituaco
    {
        public int IdMovLicitacao { get; set; }
        public int IdLicitacao { get; set; }
        public short IdSituacao { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? DsMotivacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public int? IdLeiAto { get; set; }
        public int? IdPessoa { get; set; }
        public DateTime? DtBaseTce { get; set; }
    }
}
