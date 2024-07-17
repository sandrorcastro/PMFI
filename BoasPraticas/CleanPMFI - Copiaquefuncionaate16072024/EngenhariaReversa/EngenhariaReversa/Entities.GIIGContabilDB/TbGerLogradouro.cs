using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerLogradouro
    {
        public TbGerLogradouro()
        {
            TbGerEnderecos = new HashSet<TbGerEndereco>();
        }

        public int Idlogradouro { get; set; }
        public string? DsTipo { get; set; }
        public string? NmLogradouro { get; set; }

        public virtual ICollection<TbGerEndereco> TbGerEnderecos { get; set; }
    }
}
