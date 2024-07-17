using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TempTbOrcReceitasOrcamentoAnual
    {
        public int IdReceitaOrcamentoAnual { get; set; }
        public int IdReceita { get; set; }
        public decimal? VlOrcado { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? DsTipo { get; set; }
    }
}
