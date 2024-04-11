using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicComposicoesComissao
{
    public int IdComposicaoComissao { get; set; }

    public int? IdAtoNomeacaoPessoa { get; set; }

    public short? IdTipoAtribuicaoComissao { get; set; }

    public short? IdNaturezaCargoServidor { get; set; }

    public string? DsCargo { get; set; }

    public int? IdLicitacao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbLicAtosNomeacaoComissaoPessoa? IdAtoNomeacaoPessoaNavigation { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }

    public virtual TbLicNaturezasCargosServidore? IdNaturezaCargoServidorNavigation { get; set; }

    public virtual TbLicTiposAtribuicaoComisso? IdTipoAtribuicaoComissaoNavigation { get; set; }
}
