using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilRepositorioDB
{
    public partial class TbDspRmsAnexo
    {
        public int IdAnexo { get; set; }
        public int? NrSequencial { get; set; }
        public string? NmAnexo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public byte[]? BnObjeto { get; set; }
        public string? DsExtencao { get; set; }
        public string? FlPublicaPortalTransparencia { get; set; }
        public string? DsObjeto { get; set; }
        public string? DsLogin { get; set; }
    }
}
