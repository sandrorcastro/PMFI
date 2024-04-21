using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoTributoLei
    {
        public int IdTributoLei { get; set; }
        public int TipoTribId { get; set; }
        public string DsTipoOperacao { get; set; } = null!;
        public int IdLei { get; set; }
        public DateTime DtInicioVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }
        public string DsLogin { get; set; } = null!;
        public DateTime DtInclusao { get; set; }
        public bool? FlExcluida { get; set; }
        public string? DsLoginExclusao { get; set; }
        public DateTime? DtExclusao { get; set; }
    }
}
