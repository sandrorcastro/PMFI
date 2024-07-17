using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAinfarquivo
{
    public int IdAinfarquivo { get; set; }

    public int? VersaoLeiaute { get; set; }

    public DateOnly? DataGeracao { get; set; }

    public string? NomeArquivo { get; set; }

    public string? Filler { get; set; }

    public DateTime DataInclusao { get; set; }

    public string UsuarioInclusao { get; set; } = null!;

    public virtual ICollection<TribAinfarquivoDetalhe> TribAinfarquivoDetalhes { get; set; } = new List<TribAinfarquivoDetalhe>();

    public virtual ICollection<TribAinfarquivoDividasLancada> TribAinfarquivoDividasLancada { get; set; } = new List<TribAinfarquivoDividasLancada>();
}
