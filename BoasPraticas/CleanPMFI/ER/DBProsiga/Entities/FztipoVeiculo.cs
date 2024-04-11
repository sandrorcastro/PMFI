using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FztipoVeiculo
{
    public int FztipoVeicId { get; set; }

    public string FztipoVeicNome { get; set; } = null!;

    public string? Flvistorialocal { get; set; }

    public bool? Flexigepontovistoria { get; set; }

    public bool? Flexigesegurovistoria { get; set; }

    public bool? Flexigeemplacvistoria { get; set; }

    public bool? Flexigecondutorvistoria { get; set; }

    public byte? Nrvistoriaprazovencto { get; set; }

    public bool? Flutilizanrveiculo { get; set; }

    public bool? Flexigepermissionario { get; set; }

    public int? Nrvigenciameses { get; set; }

    public string? Dspermissaotipo { get; set; }

    public int? Idusuariogravacao { get; set; }

    public DateTime? Dtgravacao { get; set; }

    public int? Idusuarioultalt { get; set; }

    public DateTime? Dtultalt { get; set; }

    public virtual ICollection<Fzcredencial> Fzcredencials { get; set; } = new List<Fzcredencial>();

    public virtual ICollection<FzparametrosVistoria> FzparametrosVistoria { get; set; } = new List<FzparametrosVistoria>();

    public virtual ICollection<Fzveiculo> Fzveiculos { get; set; } = new List<Fzveiculo>();
}
