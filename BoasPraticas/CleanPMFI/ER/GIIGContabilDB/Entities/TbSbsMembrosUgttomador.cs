using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsMembrosUgttomador
{
    public int IdMembro { get; set; }

    public int? IdSubvencaoSocial { get; set; }

    public int? IdPessoa { get; set; }

    public string? DsCargo { get; set; }

    public string? CdTipoAto { get; set; }

    public string? NrAto { get; set; }

    public DateTime? DtNomeacao { get; set; }

    public DateTime? DtExoneracao { get; set; }

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubvencaoSocialNavigation { get; set; }
}
