using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class AgeAgendamento
{
    public long AgendamId { get; set; }

    public long? ConId { get; set; }

    public long? AgendaId { get; set; }

    public long? ServId { get; set; }

    public DateTime? AgendamData { get; set; }

    public DateTime? AgendamHora { get; set; }

    /// <summary>
    /// Assunto
    /// </summary>
    public int? AssunId { get; set; }

    public string? AgendamComplem { get; set; }

    public string? AgendamSituacao { get; set; }

    public long? AgendamIdanterior { get; set; }

    public string? AgendamSitAtend { get; set; }

    public long? TipoAgeId { get; set; }

    public virtual ICollection<AgeAnotacao> AgeAnotacaos { get; set; } = new List<AgeAnotacao>();

    public virtual AgeAgendum? Agenda { get; set; }

    public virtual AgeAssunto? Assun { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual Servidore? Serv { get; set; }

    public virtual AgeTipoAgendamento? TipoAge { get; set; }
}
