using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class HabTipoAtendimento
{
    public int TipoAtendimentoId { get; set; }

    /// <summary>
    /// Aquisicao Casa Própria, etc
    /// </summary>
    public string? NmAtendimento { get; set; }

    public string? Observacao { get; set; }

    public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; } = new List<HabAtendimento>();

    public virtual ICollection<HabDocumento> Documentos { get; set; } = new List<HabDocumento>();
}
