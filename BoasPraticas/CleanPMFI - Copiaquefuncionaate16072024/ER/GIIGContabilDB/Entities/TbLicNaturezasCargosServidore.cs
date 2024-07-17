using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicNaturezasCargosServidore
{
    public short IdNaturezaCargoServidor { get; set; }

    public string? NmNaturezaCargoServidor { get; set; }

    public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; } = new List<TbLicAtosNomeacaoComissaoPessoa>();

    public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; } = new List<TbLicComposicoesComissao>();
}
