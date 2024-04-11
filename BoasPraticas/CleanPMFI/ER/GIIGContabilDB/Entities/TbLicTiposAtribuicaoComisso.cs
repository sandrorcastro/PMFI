using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTiposAtribuicaoComisso
{
    public short IdTipoAtribuicaoComissao { get; set; }

    public string? NmTipoAtribuicaoComissao { get; set; }

    public short? CdTc { get; set; }

    public virtual ICollection<TbLicAtosNomeacaoComissaoPessoa> TbLicAtosNomeacaoComissaoPessoas { get; set; } = new List<TbLicAtosNomeacaoComissaoPessoa>();

    public virtual ICollection<TbLicComposicoesComissao> TbLicComposicoesComissaos { get; set; } = new List<TbLicComposicoesComissao>();
}
