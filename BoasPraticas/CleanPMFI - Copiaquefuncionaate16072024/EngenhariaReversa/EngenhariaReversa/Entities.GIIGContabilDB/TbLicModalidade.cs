using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicModalidade
    {
        public TbLicModalidade()
        {
            TbLicLimites = new HashSet<TbLicLimite>();
            TbLicNaturezasProcedimentos = new HashSet<TbLicNaturezasProcedimento>();
            IdSetorCompras = new HashSet<TbDspSetoresCompra>();
        }

        public short IdModalidade { get; set; }
        public string? DsModalidade { get; set; }
        public string? FlPadraoTce { get; set; }
        public bool? FlNumeraPorNatureza { get; set; }

        public virtual ICollection<TbLicLimite> TbLicLimites { get; set; }
        public virtual ICollection<TbLicNaturezasProcedimento> TbLicNaturezasProcedimentos { get; set; }

        public virtual ICollection<TbDspSetoresCompra> IdSetorCompras { get; set; }
    }
}
