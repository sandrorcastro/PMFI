using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSimuladosEmpresaDiv
{
    public int SimuEmprDivId { get; set; }

    public int SimuEmprId { get; set; }

    public int TipoTribId { get; set; }

    public DateTime SimuEmprDivVenc { get; set; }

    public int SimuEmprDivParc { get; set; }

    public int SimuEmprDivMes { get; set; }

    public int TipoBxId { get; set; }

    public decimal SimuEmprDivValor { get; set; }

    public virtual TribSimuladosEmpresa SimuEmpr { get; set; } = null!;

    public virtual TribTipoBaixa TipoBx { get; set; } = null!;

    public virtual TribTipoTributo TipoTrib { get; set; } = null!;
}
