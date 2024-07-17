using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocacaoFrotum
{
    public long LocacaoId { get; set; }

    public long? LocVeiculoId { get; set; }

    public long? LocVidContrato { get; set; }

    public DateTime? LocVdataInicio { get; set; }

    public DateTime? LocVdataDevolucao { get; set; }

    public virtual Veiculo? LocVeiculo { get; set; }

    public virtual DepuContrato? LocVidContratoNavigation { get; set; }
}
