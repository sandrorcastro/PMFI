using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbMapObjetivosPlanejamento
    {
        public int IdObjetivo { get; set; }
        public int IdAcao { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapObjetivo IdObjetivoNavigation { get; set; } = null!;
    }
}
