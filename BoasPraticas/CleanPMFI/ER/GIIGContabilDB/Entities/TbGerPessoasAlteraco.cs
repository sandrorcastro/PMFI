using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerPessoasAlteraco
{
    public int IdPessoaAlteracao { get; set; }

    public int? IdPessoa { get; set; }

    public string? NmRazaoSocial { get; set; }

    public string? NmRazaoSocialAnterior { get; set; }

    public DateTime? DtInicioVigencia { get; set; }

    public string? DsMotivo { get; set; }

    public string? Dslogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? NmFantasia { get; set; }

    public string? NmFantasiaAnterior { get; set; }

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
}
