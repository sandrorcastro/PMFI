using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubExibicaoPessoal
    {
        public short Idempresa { get; set; }
        public short IdSistema { get; set; }
        public short? NrMes { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? Dslogin { get; set; }
        public string? DsIp { get; set; }
    }
}
