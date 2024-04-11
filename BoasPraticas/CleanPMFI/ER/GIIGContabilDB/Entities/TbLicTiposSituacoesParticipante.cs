using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTiposSituacoesParticipante
{
    public short IdTipoSituacaoParticipante { get; set; }

    public string? DsTipoSituacaoParticipante { get; set; }

    public virtual ICollection<TbLicParticipantesSituacao> TbLicParticipantesSituacaos { get; set; } = new List<TbLicParticipantesSituacao>();
}
