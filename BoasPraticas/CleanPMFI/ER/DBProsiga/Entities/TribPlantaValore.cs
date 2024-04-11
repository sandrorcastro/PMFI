using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribPlantaValore
{
    public int PlantaValAno { get; set; }

    public int TipoConId { get; set; }

    public int EstrutId { get; set; }

    public int CategId { get; set; }

    public decimal? PlantaValValorM2 { get; set; }

    /// <summary>
    /// Pode ser por &apos;Transferencia&apos; ou &apos;Manual&apos;
    /// </summary>
    public string OrigemCadastro { get; set; } = null!;

    public string? UsuarioInclusao { get; set; }

    public string? Host { get; set; }

    public DateTime? Data { get; set; }

    public virtual TribCategoriaEdificacao Categ { get; set; } = null!;

    public virtual TribEstruturaParede Estrut { get; set; } = null!;

    public virtual TribTiposConstrucao TipoCon { get; set; } = null!;
}
