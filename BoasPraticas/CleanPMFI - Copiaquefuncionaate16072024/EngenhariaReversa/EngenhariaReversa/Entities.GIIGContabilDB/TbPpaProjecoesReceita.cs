using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaProjecoesReceita
    {
        public int IdReceita { get; set; }
        public short NrAnoLdo { get; set; }
        public short NrVersao { get; set; }
        public decimal? VlEstimado { get; set; }
        public string? DsTpComando { get; set; }

        public virtual TbOrcReceita IdReceitaNavigation { get; set; } = null!;
    }
}
