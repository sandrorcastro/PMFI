using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProtestoLoteCdahistoricoSituacaoDividum
{
    public long IdCdahistSitDivida { get; set; }

    public long CertidaoDaid { get; set; }

    public int IdLote { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public int TipoDivIdorigem { get; set; }

    public int TipoDivIddestino { get; set; }

    public string? SituacaoOrigem { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsUsuarioAlteracao { get; set; }

    public virtual TribCertidaoDum CertidaoDa { get; set; } = null!;

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribProtestoLote IdLoteNavigation { get; set; } = null!;

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }

    public virtual TribTipoDividum TipoDivIddestinoNavigation { get; set; } = null!;

    public virtual TribTipoDividum TipoDivIdorigemNavigation { get; set; } = null!;
}
