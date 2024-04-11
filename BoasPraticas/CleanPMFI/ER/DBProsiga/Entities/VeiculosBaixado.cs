using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VeiculosBaixado
{
    public long VebIdBaixa { get; set; }

    public long? VebVeiculoId { get; set; }

    public int? VebIdAtoBaixa { get; set; }

    public DateTime? VebDataBaixa { get; set; }

    public decimal? VebValorBaixa { get; set; }

    public int? VebNumParcelas { get; set; }

    public decimal? VebLanceMinimo { get; set; }

    public long? VebContribuinteId { get; set; }

    public string? VebObservacao { get; set; }

    public short? VebNrAnoLic { get; set; }

    public short? VebNrLicitacao { get; set; }

    public short? VebIdModalidade { get; set; }

    public virtual Contribuinte? VebContribuinte { get; set; }

    public virtual AtoBaixa? VebIdAtoBaixaNavigation { get; set; }

    public virtual Veiculo? VebVeiculo { get; set; }
}
