using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaObjetivo
    {
        public TbPlaObjetivo()
        {
            TbPlaIniciativas = new HashSet<TbPlaIniciativa>();
            TbPlaObjetivosMeta = new HashSet<TbPlaObjetivosMeta>();
        }

        public int IdObjetivo { get; set; }
        public int? IdVersaoCriacao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? CdObjetivo { get; set; }
        public string? NmObjetivo { get; set; }
        public string? DsObjetivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbPlaIniciativa> TbPlaIniciativas { get; set; }
        public virtual ICollection<TbPlaObjetivosMeta> TbPlaObjetivosMeta { get; set; }
    }
}
