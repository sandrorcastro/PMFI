using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbconsultapreviazoneamentoresposta
    {
        public int Idconsultazoneamento { get; set; }
        public int Idconsulta { get; set; }
        public string Atividade { get; set; } = null!;
        public short ZotlId { get; set; }
        public int? Idpergunta { get; set; }
        public int? Idresposta { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual Tbconsultaprevium IdconsultaNavigation { get; set; } = null!;
        public virtual Tbtribativpergunta? IdperguntaNavigation { get; set; }
        public virtual Tbtribativresposta? IdrespostaNavigation { get; set; }
        public virtual TribZonaTipoLiberacao Zotl { get; set; } = null!;
    }
}
