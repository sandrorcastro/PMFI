using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SeriTurOrigemTuristaCidadao
{
    public long IdmovOrigem { get; set; }

    public DateTime? Data { get; set; }

    public long? Idpit { get; set; }

    public string UsuId { get; set; } = null!;

    public int? Iduf { get; set; }

    public virtual ICollection<SeriTurMovAtendimento> SeriTurMovAtendimentos { get; set; } = new List<SeriTurMovAtendimento>();

    public virtual ICollection<SeriTurUf> Idufs { get; set; } = new List<SeriTurUf>();
}
