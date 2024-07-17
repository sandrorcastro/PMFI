using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblTipoDesconto
    {
        public int Idtipodesconto { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string Idservico { get; set; } = null!;
        public string? Stobservacao { get; set; }
        public string? Stformato { get; set; }
        public string? Stformula { get; set; }
        public string? Stcamporesultado { get; set; }

        public virtual NfseTblServico IdservicoNavigation { get; set; } = null!;
    }
}
