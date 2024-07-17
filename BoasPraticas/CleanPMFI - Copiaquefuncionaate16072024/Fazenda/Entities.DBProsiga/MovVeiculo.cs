using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class MovVeiculo
{
    public long MvId { get; set; }

    public long? MvVeiculoId { get; set; }

    public long? MvServidorIdAnt { get; set; }

    public long? MvServidorId { get; set; }

    public string? MvMotivo { get; set; }

    public DateTime? MvData { get; set; }

    public DateTime? MvDtConfirmacao { get; set; }

    public string? MvTipoMovVeiculo { get; set; }

    public string? MvSituacao { get; set; }

    public string? MvObs { get; set; }

    public virtual Veiculo? MvVeiculo { get; set; }
}
