using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Tbconsultapreviadocumentoresposta
{
    public int Idconsultadocumento { get; set; }

    public int Idconsulta { get; set; }

    public string Atividade { get; set; } = null!;

    public int Iddocumento { get; set; }

    public int? Idpergunta { get; set; }

    public int? Idresposta { get; set; }

    public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;

    public virtual Tbconsultaprevium IdconsultaNavigation { get; set; } = null!;

    public virtual Tbtribativpergunta? IdperguntaNavigation { get; set; }

    public virtual Tbtribativresposta? IdrespostaNavigation { get; set; }
}
