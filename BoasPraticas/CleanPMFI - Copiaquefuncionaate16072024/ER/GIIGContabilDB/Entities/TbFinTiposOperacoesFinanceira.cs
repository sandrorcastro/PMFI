using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinTiposOperacoesFinanceira
{
    public short IdTipoOperacaoFinanceira { get; set; }

    public string? DsTipoOperacaoFinanceira { get; set; }

    public string? FlLancaManual { get; set; }

    public string? FlExigeIdContaTransferencia { get; set; }

    public string? FlExigeIdContaContabilContrapartida { get; set; }

    public string? FlExigeIdOrigemDestino { get; set; }

    public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; } = new List<TbFinContasContabeisLancamentosAnalisador>();

    public virtual ICollection<TbFinDiarioTesourarium> TbFinDiarioTesouraria { get; set; } = new List<TbFinDiarioTesourarium>();

    public virtual ICollection<TbFinTiposDocumentoFinanceiro> IdTipoDocFinanceiros { get; set; } = new List<TbFinTiposDocumentoFinanceiro>();
}
