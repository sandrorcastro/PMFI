using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribSecao
    {
        public TribSecao()
        {
            TribSecaoVlrM2pAnos = new HashSet<TribSecaoVlrM2pAno>();
            TipoTribs = new HashSet<TribTipoTributo>();
        }

        public int SecaoId { get; set; }
        public string? Secao { get; set; }
        public decimal? VlrMetroQuadrado { get; set; }
        public int? QuadraId { get; set; }
        public int? LogradId { get; set; }

        public virtual TribQuadraLograd? TribQuadraLograd { get; set; }
        public virtual ICollection<TribSecaoVlrM2pAno> TribSecaoVlrM2pAnos { get; set; }

        public virtual ICollection<TribTipoTributo> TipoTribs { get; set; }
    }
}
