using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tribedificacoesdivergencium
    {
        public int Idedificacaodivergencia { get; set; }
        public long EdificacaoId { get; set; }
        public int Iddivergencia { get; set; }
        public string? Dsobservacao { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
        public virtual Tbrevisaodivergencium IddivergenciaNavigation { get; set; } = null!;
    }
}
