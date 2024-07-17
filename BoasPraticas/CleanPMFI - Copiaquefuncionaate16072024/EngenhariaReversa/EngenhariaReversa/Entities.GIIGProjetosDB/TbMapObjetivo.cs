using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbMapObjetivo
    {
        public TbMapObjetivo()
        {
            TbMapObjetivosPlanejamentos = new HashSet<TbMapObjetivosPlanejamento>();
            TbPrjProjetos = new HashSet<TbPrjProjeto>();
        }

        public int IdObjetivo { get; set; }
        public int IdObjetivoMacro { get; set; }
        public string? DsObjetivo { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapObjetivosMacro IdObjetivoMacroNavigation { get; set; } = null!;
        public virtual ICollection<TbMapObjetivosPlanejamento> TbMapObjetivosPlanejamentos { get; set; }
        public virtual ICollection<TbPrjProjeto> TbPrjProjetos { get; set; }
    }
}
