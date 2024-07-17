using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbObrTipoObrasServico
    {
        public TbObrTipoObrasServico()
        {
            TbObrIntervencaos = new HashSet<TbObrIntervencao>();
        }

        public short IdtipoObraServ { get; set; }
        public string DsTipoObraServ { get; set; } = null!;
        public short? CdTipoObra { get; set; }
        public string DsDcadastroPrevioLoc { get; set; } = null!;

        public virtual ICollection<TbObrIntervencao> TbObrIntervencaos { get; set; }
    }
}
