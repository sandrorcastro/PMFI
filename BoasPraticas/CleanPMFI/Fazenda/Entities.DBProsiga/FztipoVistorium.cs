using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FztipoVistorium
{
    public long FztipoVistId { get; set; }

    public string? FztipoVistNome { get; set; }

    public virtual ICollection<FzparametrosVistoria> FzparametrosVistoria { get; set; } = new List<FzparametrosVistoria>();

    public virtual ICollection<FzvistoriaVeiculo> FzvistoriaVeiculos { get; set; } = new List<FzvistoriaVeiculo>();

    public virtual ICollection<Fztaxa> Txes { get; set; } = new List<Fztaxa>();
}
