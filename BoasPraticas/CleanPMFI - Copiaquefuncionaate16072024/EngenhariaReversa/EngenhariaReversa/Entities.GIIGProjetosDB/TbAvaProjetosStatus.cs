using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbAvaProjetosStatus
    {
        public int IdProjetoStatus { get; set; }
        public int IdProjeto { get; set; }
        public string? DsStatus { get; set; }
        public string? DsParecer { get; set; }
        public DateTime? DtParecer { get; set; }
        public string? FlForceIn { get; set; }
        public string? FlForceOut { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtCadastro { get; set; }

        public virtual TbPrjProjeto IdProjetoNavigation { get; set; } = null!;
    }
}
