using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoProcessoTributo
    {
        public int TipoProcessoTributoId { get; set; }
        public int TipoProcessoId { get; set; }
        public int TipoTribId { get; set; }
        public string? DsFormulaTributo { get; set; }
        public string? DsSqlFormulaTributo { get; set; }
        public string? DsFormulaDesconto { get; set; }
        public string? DsSqlFormulaDesconto { get; set; }
        public string? DsFormulaTipoBaixa { get; set; }
        public string? DsSqlFormulaTipoBaixa { get; set; }

        public virtual TribTipoProcesso TipoProcesso { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
