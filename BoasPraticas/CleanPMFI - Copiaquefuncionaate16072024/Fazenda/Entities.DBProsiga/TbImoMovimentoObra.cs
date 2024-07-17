using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbImoMovimentoObra
{
    public long IdmovObras { get; set; }

    public string? DsMovimento { get; set; }

    public string? DsSituacao { get; set; }

    public DateTime DtMovimento { get; set; }

    public int Idobra { get; set; }

    public string Idusu { get; set; } = null!;

    public int? ModAid { get; set; }

    public short? NrAnoLic { get; set; }

    public short? NrLicitacao { get; set; }

    public short? IdModalidade { get; set; }

    public virtual TbImoObra IdobraNavigation { get; set; } = null!;

    public virtual Usuario IdusuNavigation { get; set; } = null!;

    public virtual ICollection<TbImoMovObrasDepuDesp> TbImoMovObrasDepuDesps { get; set; } = new List<TbImoMovObrasDepuDesp>();
}
