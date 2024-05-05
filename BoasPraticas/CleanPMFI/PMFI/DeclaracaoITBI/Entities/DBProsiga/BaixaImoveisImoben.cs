using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class BaixaImoveisImoben
{
    public long IdbaixaImoBens { get; set; }

    public string ImoInscricao { get; set; } = null!;

    public int ImoIdatoBaixa { get; set; }

    public DateTime ImoDataBaixa { get; set; }

    public decimal? ImoValorBaixa { get; set; }

    public int? ImoNumDeParcelas { get; set; }

    public string? ImoCnpjFilial { get; set; }

    public long? ImoIdcontribuinte { get; set; }

    public short? ImoNrAnoLic { get; set; }

    public short? ImoNrLicitacao { get; set; }

    public short? ImoIdModalidade { get; set; }

    public virtual AtoBaixa ImoIdatoBaixaNavigation { get; set; } = null!;

    public virtual Contribuinte? ImoIdcontribuinteNavigation { get; set; }

    public virtual ImobensImovei? ImobensImovei { get; set; }
}
