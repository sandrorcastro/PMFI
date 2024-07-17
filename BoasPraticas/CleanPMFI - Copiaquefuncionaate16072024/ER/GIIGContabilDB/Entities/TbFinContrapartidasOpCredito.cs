using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinContrapartidasOpCredito
{
    public int IdContrapartidaOpCredito { get; set; }

    public long? IdDividaFundada { get; set; }

    public DateTime? DtOperacao { get; set; }

    public int? IdTipoOperacao { get; set; }

    public int? IdFonteContraPartida { get; set; }

    public int? IdFonteOpCredito { get; set; }

    public decimal? VlOperacao { get; set; }

    public int IdEmpenho { get; set; }

    public virtual TbOrcFonte? IdFonteContraPartidaNavigation { get; set; }

    public virtual TbOrcFonte? IdFonteOpCreditoNavigation { get; set; }

    public virtual TbFinTipoContrapartidaOpCredito? IdTipoOperacaoNavigation { get; set; }
}
