using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribDividasImoEdital
{
    public long EdiDivImoId { get; set; }

    public long? EdificacaoId { get; set; }

    public int? EdiDivImoAnoDiv { get; set; }

    public int? TipoTribId { get; set; }

    public int? EdiDivImoSubDivida { get; set; }

    public int? EdiDivImoParcela { get; set; }

    public DateTime? EdiDivImoVencimento { get; set; }

    public decimal? EdiDivImoValor { get; set; }

    public DateTime? EdiDivImoDatalanc { get; set; }

    /// <summary>
    /// id da divida dos tribdividasimo para saber qual eh a divida gerada
    /// </summary>
    public long? ImoIddivida { get; set; }

    public long? EdiDivImoNumEdital { get; set; }

    public int? EdiDivImoAnoEdital { get; set; }

    public long? TextoId { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribDividasImo? ImoIddividaNavigation { get; set; }

    public virtual TribTexto? Texto { get; set; }

    public virtual TribTipoTributo? TipoTrib { get; set; }

    public virtual ICollection<TribNotifEdital> TribNotifEditals { get; set; } = new List<TribNotifEdital>();
}
