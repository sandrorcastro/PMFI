using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicEspeciesBensServico
    {
        public TbLicEspeciesBensServico()
        {
            TbLicLicitacos = new HashSet<TbLicLicitaco>();
        }

        public short IdBemServico { get; set; }
        public string? CdBemServico { get; set; }
        public string? DsBemServico { get; set; }
        public string? FlPermiteEmpenhoDireto { get; set; }

        public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; }
    }
}
