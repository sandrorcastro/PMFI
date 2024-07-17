using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TiposDocumentosOficiai
    {
        public TiposDocumentosOficiai()
        {
            ParametroAssinaturas = new HashSet<ParametroAssinatura>();
        }

        public long IdtipoDoc { get; set; }
        public string? NomeDoc { get; set; }

        public virtual ICollection<ParametroAssinatura> ParametroAssinaturas { get; set; }
    }
}
