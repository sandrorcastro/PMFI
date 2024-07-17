using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabTipoAgendaAnexo
    {
        public int IdAnexo { get; set; }
        public int? TpAgId { get; set; }
        public string? NmAnexo { get; set; }
        public byte[]? ObjAnexo { get; set; }
        public string? NmExtensao { get; set; }
    }
}
