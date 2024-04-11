using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEmpresasTipoSituacao
{
    public int EmprSituacaoId { get; set; }

    public string? EmprSituacaoDescricao { get; set; }

    public string? EmprSituacaoInicial { get; set; }

    public string EmprSituacaoEmFuncionamento { get; set; } = null!;

    public string EmprSituacaoAltera { get; set; } = null!;

    public string? EmprSituacaoImportar { get; set; }

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();

    public virtual ICollection<TribEmpresasMovSituacao> TribEmpresasMovSituacaos { get; set; } = new List<TribEmpresasMovSituacao>();
}
