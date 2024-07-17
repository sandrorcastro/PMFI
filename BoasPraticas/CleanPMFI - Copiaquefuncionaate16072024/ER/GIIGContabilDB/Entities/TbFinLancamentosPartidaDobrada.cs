using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinLancamentosPartidaDobrada
{
    public int IdLancamento { get; set; }

    public string TpLancamento { get; set; } = null!;

    public int IdContaContabil { get; set; }

    public short? IdTipoMovimento { get; set; }

    public short? IdTipoFinanceiroPatrimonial { get; set; }

    public short? IdTipoVariacao { get; set; }

    public int? NrSequenciaAnual { get; set; }

    public virtual TbFinContasContabeisLancamento IdLancamentoNavigation { get; set; } = null!;

    public virtual TbFinTipoFinanceiroPatrimonial? IdTipoFinanceiroPatrimonialNavigation { get; set; }

    public virtual TbFinTipoMovimentoContabil? IdTipoMovimentoNavigation { get; set; }

    public virtual TbFinTipoVariacaoQualitativa? IdTipoVariacaoNavigation { get; set; }
}
