using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class LocalFisico
    {
        public LocalFisico()
        {
            Almoxarifados = new HashSet<Almoxarifado>();
            MovimentacaoMoveisEquipamentoMmeLocalFisicoAntNavigations = new HashSet<MovimentacaoMoveisEquipamento>();
            MovimentacaoMoveisEquipamentoMmeLocalFisicoNovoNavigations = new HashSet<MovimentacaoMoveisEquipamento>();
            ProcArquivamentos = new HashSet<ProcArquivamento>();
        }

        public long LocalFisicoId { get; set; }
        public string? LocalFisicoNome { get; set; }
        public int? LocId { get; set; }

        public virtual Localizacao? Loc { get; set; }
        public virtual ICollection<Almoxarifado> Almoxarifados { get; set; }
        public virtual ICollection<MovimentacaoMoveisEquipamento> MovimentacaoMoveisEquipamentoMmeLocalFisicoAntNavigations { get; set; }
        public virtual ICollection<MovimentacaoMoveisEquipamento> MovimentacaoMoveisEquipamentoMmeLocalFisicoNovoNavigations { get; set; }
        public virtual ICollection<ProcArquivamento> ProcArquivamentos { get; set; }
    }
}
