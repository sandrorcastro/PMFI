using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbPrjEscala
    {
        public int IdEscala { get; set; }
        public int IdVersao { get; set; }
        public int IdEscalaItem { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgaoResponsavel { get; set; }
        public string? CdUnidadeResposavel { get; set; }
        public decimal? VlValor { get; set; }
        public decimal? VlReciproco { get; set; }

        public virtual TbPrjEscalaIten IdEscalaItemNavigation { get; set; } = null!;
        public virtual TbMapVerso IdVersaoNavigation { get; set; } = null!;
    }
}
