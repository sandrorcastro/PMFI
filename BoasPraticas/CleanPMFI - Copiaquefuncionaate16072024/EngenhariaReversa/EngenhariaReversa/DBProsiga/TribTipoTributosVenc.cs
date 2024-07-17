using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoTributosVenc
    {
        public int TipoTribId { get; set; }
        public int Tcid { get; set; }
        public string UsaTabVencimento { get; set; } = null!;
        public short? TipoTribDiasAvencer { get; set; }
        public short? TipoTribVectoFixo { get; set; }

        public virtual TribTiposBaseCalculo Tc { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
