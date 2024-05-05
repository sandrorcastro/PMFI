using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class HabDocumento
{
    public int DocumentoId { get; set; }

    public string? DocNome { get; set; }

    /// <summary>
    /// Há exigencia que o documento seja original
    /// </summary>
    public string? DocOriginal { get; set; }

    /// <summary>
    /// HÁ exigencia que o documento seja autenticado
    /// </summary>
    public string? DocAutenticado { get; set; }

    public string? DocObservacao { get; set; }

    public string? DocOrigem { get; set; }

    public string? DocTipoOrigem { get; set; }

    public virtual ICollection<HabDocApresentado> HabDocApresentados { get; set; } = new List<HabDocApresentado>();

    public virtual ICollection<HabTipoAtendimento> TipoAtendimentos { get; set; } = new List<HabTipoAtendimento>();
}
