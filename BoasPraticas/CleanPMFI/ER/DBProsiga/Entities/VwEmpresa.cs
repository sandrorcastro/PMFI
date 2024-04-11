using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwEmpresa
{
    public long EmprCmc { get; set; }

    public string? Cnpj { get; set; }

    public string? RazaoSocial { get; set; }

    public string? NomeFantasia { get; set; }

    public string? Situacao { get; set; }

    public DateTime? DataInscricao { get; set; }

    public string? Constituicao { get; set; }

    public string? Atividades { get; set; }

    public string DomicilioTributario { get; set; } = null!;

    public string? LogradTipo { get; set; }

    public string? LogradNome { get; set; }

    public string? BaiNome { get; set; }
}
