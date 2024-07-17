using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribBaixaArquivoSuperSimple
{
    public int ArquivoId { get; set; }

    public DateTime? DataGeracao { get; set; }

    public string? Convenio { get; set; }

    public int? NumSequencia { get; set; }

    public int? TotalRegistros { get; set; }

    public decimal? ValorTotal { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataCredito { get; set; }

    public virtual ICollection<TribBaixaDetalhesArquivoSuperSimple> TribBaixaDetalhesArquivoSuperSimples { get; set; } = new List<TribBaixaDetalhesArquivoSuperSimple>();
}
