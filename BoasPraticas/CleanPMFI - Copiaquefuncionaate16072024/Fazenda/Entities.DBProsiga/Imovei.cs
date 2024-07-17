using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Imovei
{
    public string ImoCnpjfilial { get; set; } = null!;

    public string ImoInscricao { get; set; } = null!;

    public int? ImoIdloteamento { get; set; }

    public decimal? ImoAreaTotal { get; set; }

    public string? ImoNumMatricula { get; set; }

    public int? ImoRegImoveis { get; set; }

    public string? ImoTipoArea { get; set; }

    public string? ImoObservacao { get; set; }

    public DateTime? ImoDtcad { get; set; }

    public byte[]? ImoImgImovel { get; set; }

    public int? ImoIdlotAnterior { get; set; }

    public long? TpImovelId { get; set; }

    public DateTime? DtIncorporacao { get; set; }

    public decimal? ValorImovel { get; set; }

    /// <summary>
    /// Tipo da Despesa = &apos;Orçamentária&apos; ou &apos;Extra-Orçamentária&apos;
    /// </summary>
    public string? DePuTipoDespesa { get; set; }

    public int? DePuAno { get; set; }

    public int? DePuNumero { get; set; }

    public virtual Membro ImoCnpjfilialNavigation { get; set; } = null!;

    public virtual Loteamento? ImoIdloteamentoNavigation { get; set; }

    public virtual ICollection<MovImovei> MovImoveis { get; set; } = new List<MovImovei>();

    public virtual TipoImovel? TpImovel { get; set; }
}
