﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicPessoasInidonea
{
    public int IdInidoneos { get; set; }

    public short IdEmpresa { get; set; }

    public int IdPessoa { get; set; }

    public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;
}
