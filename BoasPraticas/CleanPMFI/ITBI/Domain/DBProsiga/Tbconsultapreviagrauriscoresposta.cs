using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tbconsultapreviagrauriscoresposta
    {
        public int Idconsultagraurisco { get; set; }
        public int Idconsulta { get; set; }
        public string Atividade { get; set; } = null!;
        public short SetorId { get; set; }
        public int Idrisco { get; set; }
        public int? Idpergunta { get; set; }
        public int? Idresposta { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual Tbconsultaprevium IdconsultaNavigation { get; set; } = null!;
        public virtual Tbtribativpergunta? IdperguntaNavigation { get; set; }
        public virtual Tbtribativresposta? IdrespostaNavigation { get; set; }
        public virtual Tbtribgraurisco IdriscoNavigation { get; set; } = null!;
        public virtual TribAtivSetorLicenciamento Setor { get; set; } = null!;
    }
}
