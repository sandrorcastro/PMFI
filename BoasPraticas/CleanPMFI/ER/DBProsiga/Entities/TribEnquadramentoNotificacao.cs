using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribEnquadramentoNotificacao
{
    public int IdNotificacao { get; set; }

    public int? NrNotificacao { get; set; }

    public short? NrAnoNotificacao { get; set; }

    public long ContadorId { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? TextoId { get; set; }

    public string? DsSituacao { get; set; }

    public string? TpNotificacao { get; set; }

    public virtual TribContador Contador { get; set; } = null!;

    public virtual ICollection<TribEnquadramentoNotificacaoEmpresa> TribEnquadramentoNotificacaoEmpresas { get; set; } = new List<TribEnquadramentoNotificacaoEmpresa>();
}
