using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AlmoxarifadosUsuario
    {
        public long AlmoxId { get; set; }
        public long ServidorId { get; set; }
        public string? AlmoxUsuCategoria { get; set; }
        public DateTime? AlmoxValidadeIni { get; set; }
        public DateTime? AlmoxValidadeFim { get; set; }
        public string? AlmPadrao { get; set; }

        public virtual Almoxarifado Almox { get; set; } = null!;
    }
}
