using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaProjetosAtividade
    {
        public TbPlaProjetosAtividade()
        {
            TbPlaProjetosAtividadesAcos = new HashSet<TbPlaProjetosAtividadesAco>();
            IdAcaos = new HashSet<TbOrcProgramasAco>();
            IdObjetivoMeta = new HashSet<TbPlaObjetivosMeta>();
        }

        public int IdProjetoAtividade { get; set; }
        public short? IdEscopo { get; set; }
        public short? IdVersaoCriacao { get; set; }
        public short? NrAno { get; set; }
        public string? CdProjetoAtividade { get; set; }
        public string? DsProjetoAtividade { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? TpProjetoAtividade { get; set; }
        public string? FlOrcamentaria { get; set; }

        public virtual ICollection<TbPlaProjetosAtividadesAco> TbPlaProjetosAtividadesAcos { get; set; }

        public virtual ICollection<TbOrcProgramasAco> IdAcaos { get; set; }
        public virtual ICollection<TbPlaObjetivosMeta> IdObjetivoMeta { get; set; }
    }
}
