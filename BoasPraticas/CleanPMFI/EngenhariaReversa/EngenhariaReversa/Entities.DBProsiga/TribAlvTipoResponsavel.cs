using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAlvTipoResponsavel
    {
        public TribAlvTipoResponsavel()
        {
            TribAlvDocumentoComplementos = new HashSet<TribAlvDocumentoComplemento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? DsSiglaSisObra { get; set; }

        public virtual ICollection<TribAlvDocumentoComplemento> TribAlvDocumentoComplementos { get; set; }
    }
}
