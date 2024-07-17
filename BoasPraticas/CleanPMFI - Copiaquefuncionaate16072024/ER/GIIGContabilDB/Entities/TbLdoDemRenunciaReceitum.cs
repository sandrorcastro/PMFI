using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoDemRenunciaReceitum
{
    public int IdRenunciaReceita { get; set; }

    public int? IdVersao { get; set; }

    public short? NrAnoLdo { get; set; }

    public short? NrAnoReferencia { get; set; }

    public short? IdTipoRenuncia { get; set; }

    public short? IdTipoCredito { get; set; }

    public string? DsSetorBeneficiario { get; set; }

    public decimal? VlRenuncia { get; set; }

    public string? DsCompensacao { get; set; }

    public virtual TbLdoTiposRenuncium? IdTipoRenunciaNavigation { get; set; }
}
