using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribItbidocumentoTipo
    {
        public TribItbidocumentoTipo()
        {
            TribItbiexAnexos = new HashSet<TribItbiexAnexo>();
        }

        public long ItbidocId { get; set; }
        public long ItbitipoId { get; set; }
        public string ItbidsDocumento { get; set; } = null!;
        public string ItbidsDocDescricao { get; set; } = null!;
        public bool Itbiobrigatoriedade { get; set; }
        public bool ItbidocInterno { get; set; }

        public virtual TribItbitipo Itbitipo { get; set; } = null!;
        public virtual ICollection<TribItbiexAnexo> TribItbiexAnexos { get; set; }
    }
}
