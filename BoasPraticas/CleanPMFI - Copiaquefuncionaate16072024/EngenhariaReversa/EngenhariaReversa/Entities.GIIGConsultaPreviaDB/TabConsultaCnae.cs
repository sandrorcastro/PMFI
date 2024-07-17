using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaCnae
    {
        public int ConsCnaeid { get; set; }
        public int ConsId { get; set; }
        public short? UnidId { get; set; }
        public string SubCid { get; set; } = null!;
        public string? ConsStatus { get; set; }
        public string? ConsParecer { get; set; }
        public string? ConsPermissao { get; set; }
        public DateTime? ConsDtParecer { get; set; }
        public string? FlAtividadePrincipal { get; set; }
        public string? FlExercenoEndereco { get; set; }

        public virtual TabConsultum Cons { get; set; } = null!;
    }
}
