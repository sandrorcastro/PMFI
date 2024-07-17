using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAdvertenciasDiv
{
    public int AdvertIddiv { get; set; }

    public int AdvertId { get; set; }

    /// <summary>
    /// Código de identificação da dívida.
    /// </summary>
    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public string? SaiDam { get; set; }

    public string AdvertSuspensao { get; set; } = null!;

    public virtual TribAdvertencia Advert { get; set; } = null!;

    public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }

    public virtual TribDividasEmpresa? DivEmp { get; set; }

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
}
