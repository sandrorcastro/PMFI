using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaObjetivosMeta
    {
        public TbPlaObjetivosMeta()
        {
            TbPlaObjetivosMetasLocalizadores = new HashSet<TbPlaObjetivosMetasLocalizadore>();
            IdProjetoAtividades = new HashSet<TbPlaProjetosAtividade>();
        }

        public int IdObjetivoMeta { get; set; }
        public string? DsMetaFisica { get; set; }
        public string? FlMetaQuantitativa { get; set; }
        public int IdObjetivo { get; set; }

        public virtual TbPlaObjetivo IdObjetivoNavigation { get; set; } = null!;
        public virtual ICollection<TbPlaObjetivosMetasLocalizadore> TbPlaObjetivosMetasLocalizadores { get; set; }

        public virtual ICollection<TbPlaProjetosAtividade> IdProjetoAtividades { get; set; }
    }
}
