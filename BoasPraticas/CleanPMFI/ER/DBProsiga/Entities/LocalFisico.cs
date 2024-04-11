using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class LocalFisico
{
    public long LocalFisicoId { get; set; }

    public string? LocalFisicoNome { get; set; }

    public int? LocId { get; set; }

    public virtual ICollection<Almoxarifado> Almoxarifados { get; set; } = new List<Almoxarifado>();

    public virtual Localizacao? Loc { get; set; }

    public virtual ICollection<MovimentacaoMoveisEquipamento> MovimentacaoMoveisEquipamentoMmeLocalFisicoAntNavigations { get; set; } = new List<MovimentacaoMoveisEquipamento>();

    public virtual ICollection<MovimentacaoMoveisEquipamento> MovimentacaoMoveisEquipamentoMmeLocalFisicoNovoNavigations { get; set; } = new List<MovimentacaoMoveisEquipamento>();

    public virtual ICollection<ProcArquivamento> ProcArquivamentos { get; set; } = new List<ProcArquivamento>();
}
