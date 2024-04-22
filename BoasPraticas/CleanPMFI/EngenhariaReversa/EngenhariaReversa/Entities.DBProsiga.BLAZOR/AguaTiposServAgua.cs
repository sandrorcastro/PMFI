using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AguaTiposServAgua
    {
        public AguaTiposServAgua()
        {
            AguaReqSolicServTipoServs = new HashSet<AguaReqSolicServTipoServ>();
        }

        public int TipoServId { get; set; }
        public string? TipoServNome { get; set; }
        public int? TipoServPrazoExecucao { get; set; }
        public string? TipoServLegislacao { get; set; }

        public virtual ICollection<AguaReqSolicServTipoServ> AguaReqSolicServTipoServs { get; set; }
    }
}
