using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTipoCrcf
    {
        public TbLicTipoCrcf()
        {
            IdDocCrcfs = new HashSet<TbLicDoctosCrcf>();
        }

        public short IdTipoCrcf { get; set; }
        public string? NmTipoCrcf { get; set; }
        public int? IdTexto { get; set; }
        public bool? FlNumeraAnual { get; set; }
        public string? DsSigla { get; set; }
        public bool? FlSomenteDoctosVinculados { get; set; }
        public bool? FlMostrarNumDocto { get; set; }
        public string? NmRelatorio { get; set; }

        public virtual ICollection<TbLicDoctosCrcf> IdDocCrcfs { get; set; }
    }
}
