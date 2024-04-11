using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerPessoasCategoria
{
    public int IdCategoriaPessoa { get; set; }

    public int IdCategoria { get; set; }

    public int IdPessoa { get; set; }

    public virtual TbGerCategoriasPessoa IdCategoriaNavigation { get; set; } = null!;

    public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;
}
