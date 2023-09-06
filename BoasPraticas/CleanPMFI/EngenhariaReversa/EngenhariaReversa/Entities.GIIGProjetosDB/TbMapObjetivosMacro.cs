using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbMapObjetivosMacro
    {
        public TbMapObjetivosMacro()
        {
            TbMapObjetivos = new HashSet<TbMapObjetivo>();
        }

        public int IdObjetivoMacro { get; set; }
        public int IdObjetivoGlobal { get; set; }
        public string? DsObjetivoMacro { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapObjetivosGlobai IdObjetivoGlobalNavigation { get; set; } = null!;
        public virtual ICollection<TbMapObjetivo> TbMapObjetivos { get; set; }
    }
}
