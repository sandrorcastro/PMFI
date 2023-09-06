using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbPrjCriterio
    {
        public TbPrjCriterio()
        {
            TbAvaProjetosCriterios = new HashSet<TbAvaProjetosCriterio>();
            TbPrjEscalaCriterioIdCriterioColunaNavigations = new HashSet<TbPrjEscalaCriterio>();
            TbPrjEscalaCriterioIdCriterioLinhaNavigations = new HashSet<TbPrjEscalaCriterio>();
        }

        public int IdCriterio { get; set; }
        public int IdVersao { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgaoResponsavel { get; set; }
        public string? CdUnidadeResposavel { get; set; }
        public short? NrCriterio { get; set; }
        public string? DsCriterio { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapVerso IdVersaoNavigation { get; set; } = null!;
        public virtual ICollection<TbAvaProjetosCriterio> TbAvaProjetosCriterios { get; set; }
        public virtual ICollection<TbPrjEscalaCriterio> TbPrjEscalaCriterioIdCriterioColunaNavigations { get; set; }
        public virtual ICollection<TbPrjEscalaCriterio> TbPrjEscalaCriterioIdCriterioLinhaNavigations { get; set; }
    }
}
