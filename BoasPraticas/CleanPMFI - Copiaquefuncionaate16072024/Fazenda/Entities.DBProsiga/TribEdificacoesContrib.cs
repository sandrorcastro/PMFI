using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEdificacoesContrib
{
    public long ConId { get; set; }

    public long EdificacaoId { get; set; }

    public string? Proprietario { get; set; }

    public string? Responsavel { get; set; }

    public string? Locatario { get; set; }

    public string? Correspondencia { get; set; }

    public string? UsuarioInclusao { get; set; }

    public DateTime? DataInclusao { get; set; }

    /// <summary>
    /// Identificação da Transferência
    /// </summary>
    public long? TransfId { get; set; }

    public string CoResponsavel { get; set; } = null!;

    public decimal? Percentual { get; set; }

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual TribEdificaco Edificacao { get; set; } = null!;
}
