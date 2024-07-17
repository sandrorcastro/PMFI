using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SimamtributosEquivalencium
    {
        public int TipoTribId { get; set; }
        public int TribAmcodigo { get; set; }
        public string UsuarioInclusao { get; set; } = null!;
        public DateTime DataInclusao { get; set; }
        public string HostInclusao { get; set; } = null!;

        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
        public virtual Simamtributo TribAmcodigoNavigation { get; set; } = null!;
    }
}
