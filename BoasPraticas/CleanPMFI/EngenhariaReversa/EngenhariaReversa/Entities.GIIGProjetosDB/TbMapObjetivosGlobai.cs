using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbMapObjetivosGlobai
    {
        public TbMapObjetivosGlobai()
        {
            TbMapObjetivosMacros = new HashSet<TbMapObjetivosMacro>();
        }

        public int IdObjetivoGlobal { get; set; }
        public int IdVersao { get; set; }
        public string? DsObjetivoGlobal { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapVerso IdVersaoNavigation { get; set; } = null!;
        public virtual ICollection<TbMapObjetivosMacro> TbMapObjetivosMacros { get; set; }
    }
}
