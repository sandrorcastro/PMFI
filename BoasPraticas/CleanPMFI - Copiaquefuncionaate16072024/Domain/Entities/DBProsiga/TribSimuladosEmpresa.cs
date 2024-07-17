using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSimuladosEmpresa
    {
        public TribSimuladosEmpresa()
        {
            TribSimuladosEmpresaDivs = new HashSet<TribSimuladosEmpresaDiv>();
        }

        public int SimuEmprId { get; set; }
        public long EmprCmc { get; set; }
        public int SimuEmprAno { get; set; }
        public DateTime SimuEmprDataBase { get; set; }
        public int? EmprSituacaoId { get; set; }
        public int TalvId { get; set; }

        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual ICollection<TribSimuladosEmpresaDiv> TribSimuladosEmpresaDivs { get; set; }
    }
}
