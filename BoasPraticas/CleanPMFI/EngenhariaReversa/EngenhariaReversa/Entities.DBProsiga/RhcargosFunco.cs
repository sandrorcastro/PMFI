using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class RhcargosFunco
    {
        public RhcargosFunco()
        {
            EdumovimentoLotacaos = new HashSet<EdumovimentoLotacao>();
            RhcargoFuncaoLocals = new HashSet<RhcargoFuncaoLocal>();
            RhdadosFuncionaiCargoFuncIdatualNavigations = new HashSet<RhdadosFuncionai>();
            RhdadosFuncionaiCargoFuncs = new HashSet<RhdadosFuncionai>();
        }

        public long CargoFuncId { get; set; }
        public string? CargoFuncNome { get; set; }

        public virtual ICollection<EdumovimentoLotacao> EdumovimentoLotacaos { get; set; }
        public virtual ICollection<RhcargoFuncaoLocal> RhcargoFuncaoLocals { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiCargoFuncIdatualNavigations { get; set; }
        public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiCargoFuncs { get; set; }
    }
}
