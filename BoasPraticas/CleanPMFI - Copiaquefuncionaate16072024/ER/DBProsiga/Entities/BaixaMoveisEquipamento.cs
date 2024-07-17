using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class BaixaMoveisEquipamento
{
    public long IdbaixaMovEquip { get; set; }

    public long? MebIdmovEquip { get; set; }

    public long? MebContribuinteId { get; set; }

    public int? MebIdatoBaixa { get; set; }

    public DateTime? MebDataBaixa { get; set; }

    public decimal? MebValorBaixa { get; set; }

    public int? MebDeParcelas { get; set; }

    public long? AcesMovEquipId { get; set; }

    public short? MebNrAnoLic { get; set; }

    public short? MebNrLicitacao { get; set; }

    public short? MebIdModalidade { get; set; }

    public virtual Contribuinte? MebContribuinte { get; set; }

    public virtual AtoBaixa? MebIdatoBaixaNavigation { get; set; }

    public virtual MoveisEquipamento? MebIdmovEquipNavigation { get; set; }
}
