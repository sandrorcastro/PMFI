using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbCntTiposRedimensionamento
{
    public short IdTipoRedimensionamento { get; set; }

    public string? DsTipoRedimensionamento { get; set; }

    public decimal? VlPercentual { get; set; }

    public virtual ICollection<TbCntAtosContratuaisItensLicitacao> TbCntAtosContratuaisItensLicitacaos { get; set; } = new List<TbCntAtosContratuaisItensLicitacao>();
}
