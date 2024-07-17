using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbAvaProjetosCriterio
    {
        public int IdProjeto { get; set; }
        public int IdCriterio { get; set; }
        public int IdCriterioPeso { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtCadastroUltimaAlteracao { get; set; }
        public string? DsLoginUltimaAlteracao { get; set; }

        public virtual TbPrjCriterio IdCriterioNavigation { get; set; } = null!;
        public virtual TbPrjCriteriosPeso IdCriterioPesoNavigation { get; set; } = null!;
        public virtual TbPrjProjeto IdProjetoNavigation { get; set; } = null!;
    }
}
