using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicTecnica
{
    public int IdTecnica { get; set; }

    public short? IdEmpresa { get; set; }

    public string? DsTecnica { get; set; }

    public string? FlMultiplaEscolha { get; set; }

    public virtual ICollection<TbLicLicitacaoTecnica> TbLicLicitacaoTecnicas { get; set; } = new List<TbLicLicitacaoTecnica>();

    public virtual ICollection<TbLicParticipanteTecnica> TbLicParticipanteTecnicas { get; set; } = new List<TbLicParticipanteTecnica>();

    public virtual ICollection<TbLicTecnicaOpco> TbLicTecnicaOpcos { get; set; } = new List<TbLicTecnicaOpco>();
}
