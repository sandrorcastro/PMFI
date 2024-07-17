using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tbb
{
    public long MovSitId { get; set; }

    public long EmprCmc { get; set; }

    public DateTime? MovSitData { get; set; }

    public int? EmprSituacaoId { get; set; }

    public string? MovSitMotivo { get; set; }

    public string? MovSitTipo { get; set; }

    public string? MovSitProtocoloAnt { get; set; }

    public string? MovSitObservacao { get; set; }

    public long? MovSitProtocNum { get; set; }

    public int? MovSitProtocAno { get; set; }

    public string? MovSitCnpj { get; set; }

    public string? MovSitRazaoSocial { get; set; }

    public string? UsuarioInclusao { get; set; }
}
