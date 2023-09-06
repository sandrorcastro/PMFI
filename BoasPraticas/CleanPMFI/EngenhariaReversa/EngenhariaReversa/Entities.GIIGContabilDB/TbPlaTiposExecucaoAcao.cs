using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaTiposExecucaoAcao
    {
        public TbPlaTiposExecucaoAcao()
        {
            TbPlaAcoesMovimentos = new HashSet<TbPlaAcoesMovimento>();
        }

        public short IdTipoExecucaoAcao { get; set; }
        public string? DsTipoExecucaoAcao { get; set; }

        public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; }
    }
}
