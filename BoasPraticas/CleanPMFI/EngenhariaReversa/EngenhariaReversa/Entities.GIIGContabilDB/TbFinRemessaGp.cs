using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinRemessaGp
    {
        public int IdRemssa { get; set; }
        public short? NrAno { get; set; }
        public int? NrRemessa { get; set; }
        public short? NrMesComp { get; set; }
        public int? IdCc { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? NmArquivo { get; set; }
        public decimal? VlRemessa { get; set; }
    }
}
