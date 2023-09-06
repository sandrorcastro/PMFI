using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissTributosDespachosEmpresa
    {
        public int TipoTribId { get; set; }
        public long IddespachoEmpresa { get; set; }
        public DateTime? DataCadTaxaDespacho { get; set; }

        public virtual FissDespachosEmpresa IddespachoEmpresaNavigation { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
