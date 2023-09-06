using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaAnexo
    {
        public int CoanId { get; set; }
        public byte[]? CoanAnexo { get; set; }
        public string? CoanContentType { get; set; }
        public int? ConsId { get; set; }
        public string? CoanDescricao { get; set; }
        public string? CoanExtensao { get; set; }

        public virtual TabConsultum? Cons { get; set; }
    }
}
