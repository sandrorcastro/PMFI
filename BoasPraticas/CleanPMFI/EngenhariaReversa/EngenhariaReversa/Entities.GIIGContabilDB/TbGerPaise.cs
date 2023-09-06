using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerPaise
    {
        public TbGerPaise()
        {
            TbGerCidades = new HashSet<TbGerCidade>();
        }

        public int Idpais { get; set; }
        public string? NmPais { get; set; }
        public string? DsSigla { get; set; }

        public virtual ICollection<TbGerCidade> TbGerCidades { get; set; }
    }
}
