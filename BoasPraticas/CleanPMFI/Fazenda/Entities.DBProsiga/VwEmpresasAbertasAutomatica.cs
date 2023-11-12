using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VwEmpresasAbertasAutomatica
{
    public long EmprCmc { get; set; }

    public string? Cnpj { get; set; }

    public string? RazaoSocial { get; set; }

    public string? NomeFantasia { get; set; }

    public DateTime? EmprDataInscricao { get; set; }

    public string? Constituicao { get; set; }

    public string? Atividades { get; set; }

    public string DomicilioTributario { get; set; } = null!;

    public string GerouTaxaInscricao { get; set; } = null!;

    public string GerouComprovanteInscricao { get; set; } = null!;
}
