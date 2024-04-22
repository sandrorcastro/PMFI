using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEdifParamCalculo
    {
        public long EdificacaoId { get; set; }
        public int TparamId { get; set; }
        public int ParamId { get; set; }
        public int? Valor { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
        public virtual TribParamCalculo TribParamCalculo { get; set; } = null!;
    }
}
