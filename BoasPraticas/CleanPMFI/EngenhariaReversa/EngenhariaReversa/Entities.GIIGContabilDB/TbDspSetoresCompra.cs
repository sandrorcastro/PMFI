using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspSetoresCompra
    {
        public TbDspSetoresCompra()
        {
            TbDspRms = new HashSet<TbDspRm>();
            TbDspSetoresCompraOrgaosUnidades = new HashSet<TbDspSetoresCompraOrgaosUnidade>();
            TbLicLicitacos = new HashSet<TbLicLicitaco>();
            IdModalidades = new HashSet<TbLicModalidade>();
        }

        public short IdSetorCompra { get; set; }
        public short? IdEmpresa { get; set; }
        public string? NmSetorCompra { get; set; }
        public bool? FlCpl { get; set; }

        public virtual ICollection<TbDspRm> TbDspRms { get; set; }
        public virtual ICollection<TbDspSetoresCompraOrgaosUnidade> TbDspSetoresCompraOrgaosUnidades { get; set; }
        public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; }

        public virtual ICollection<TbLicModalidade> IdModalidades { get; set; }
    }
}
