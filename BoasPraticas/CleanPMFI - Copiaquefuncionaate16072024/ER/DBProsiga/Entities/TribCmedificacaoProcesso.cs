using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCmedificacaoProcesso
{
    public long CmprocId { get; set; }

    public long EdificacaoId { get; set; }

    public string? CmprocEdifSituacao { get; set; }

    public string? CmprocEdifPavimentacao { get; set; }

    public string? CmprocEdifEdital { get; set; }

    public string? CmprocEdifNumeroOficio { get; set; }

    public long? ConId { get; set; }

    public int? CmprocEdifQtdeParc { get; set; }

    public string? CmprocEdifAceitaObra { get; set; }

    public decimal? CmprocEdifTestadasMetragem { get; set; }

    public decimal? CmprocEdifValor { get; set; }

    public virtual TribCmprocesso Cmproc { get; set; } = null!;

    public virtual Contribuinte? Con { get; set; }

    public virtual TribEdificaco Edificacao { get; set; } = null!;
}
