using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEdificacoesContribAnteriore
{
    public long IdedifAnterior { get; set; }

    public long ConId { get; set; }

    public long EdificacaoId { get; set; }

    public string? Proprietario { get; set; }

    public string? Responsavel { get; set; }

    public string? Locatario { get; set; }

    public string? Correspondencia { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? CoResponsavel { get; set; }

    public string? Observacao { get; set; }

    public decimal? Percentual { get; set; }
}
