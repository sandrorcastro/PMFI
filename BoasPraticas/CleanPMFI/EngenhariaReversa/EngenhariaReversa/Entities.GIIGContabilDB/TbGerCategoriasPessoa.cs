using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerCategoriasPessoa
    {
        public TbGerCategoriasPessoa()
        {
            TbGerPessoasCategoria = new HashSet<TbGerPessoasCategoria>();
            IdDocCrcfs = new HashSet<TbLicDoctosCrcf>();
        }

        public int IdCategoria { get; set; }
        public string? NmCategoria { get; set; }

        public virtual ICollection<TbGerPessoasCategoria> TbGerPessoasCategoria { get; set; }

        public virtual ICollection<TbLicDoctosCrcf> IdDocCrcfs { get; set; }
    }
}
