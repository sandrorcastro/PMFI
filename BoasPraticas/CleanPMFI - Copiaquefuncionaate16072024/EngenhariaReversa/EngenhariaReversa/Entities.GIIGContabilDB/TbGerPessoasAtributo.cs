using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerPessoasAtributo
    {
        public int IdPessoa { get; set; }
        public string IdAtributo { get; set; } = null!;
        public string? VlAtributo { get; set; }

        public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;
    }
}
