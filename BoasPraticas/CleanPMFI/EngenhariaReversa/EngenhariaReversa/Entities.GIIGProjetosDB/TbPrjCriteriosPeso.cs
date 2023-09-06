using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbPrjCriteriosPeso
    {
        public TbPrjCriteriosPeso()
        {
            TbAvaProjetosCriterios = new HashSet<TbAvaProjetosCriterio>();
        }

        public int IdCriterioPeso { get; set; }
        public int IdVersao { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgaoResponsavel { get; set; }
        public string? CdUnidadeResposavel { get; set; }
        public string? DsPeso { get; set; }
        public int? NrPeso { get; set; }

        public virtual ICollection<TbAvaProjetosCriterio> TbAvaProjetosCriterios { get; set; }
    }
}
