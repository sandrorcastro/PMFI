using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FzitensDeVistorium
{
    public int ItemVistId { get; set; }

    public string? ItemVistNome { get; set; }

    public virtual ICollection<FzitensVistoriado> FzitensVistoriados { get; set; } = new List<FzitensVistoriado>();

    public virtual ICollection<FzparametrosVistoria> FzparametrosVistoria { get; set; } = new List<FzparametrosVistoria>();
}
