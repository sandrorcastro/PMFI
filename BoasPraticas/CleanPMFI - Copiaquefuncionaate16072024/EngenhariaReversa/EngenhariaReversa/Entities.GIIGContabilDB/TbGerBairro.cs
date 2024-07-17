using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerBairro
    {
        public TbGerBairro()
        {
            TbGerEnderecos = new HashSet<TbGerEndereco>();
        }

        public int Idbairro { get; set; }
        public string? NmBairro { get; set; }

        public virtual ICollection<TbGerEndereco> TbGerEnderecos { get; set; }
    }
}
