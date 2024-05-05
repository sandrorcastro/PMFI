using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SisTarefa
{
    /// <summary>
    /// Código de identificação do tipo do JOB.
    /// </summary>
    public int TiJoId { get; set; }

    /// <summary>
    /// Nome do JOB que aparece para o usuário. Pode ser: CalculoIPTU, CalculoRenovacao, ExtratoUnificado  e etc...
    /// </summary>
    public string? TiJoNome { get; set; }

    /// <summary>
    /// Nome do procedimento (stored procedure) que banco deve executar.
    /// </summary>
    public string? TiJoNomeProcedimento { get; set; }

    /// <summary>
    /// Descrever o objetivo do JOB.
    /// </summary>
    public string? TiJoObjetivo { get; set; }

    /// <summary>
    /// Este atributo descreve se deve ser chamado um metodo ou um Job (BANCO,APLICAÇÃO)
    /// </summary>
    public string? TiJoTipo { get; set; }

    /// <summary>
    /// Define a classe que contem o methodo as ser chamado
    /// </summary>
    public string? TiJoPathFileDll { get; set; }

    public string? TiJoNameSpace { get; set; }

    public virtual ICollection<SisTarefaAgendum> SisTarefaAgenda { get; set; } = new List<SisTarefaAgendum>();

    public virtual ICollection<SisTarefaParametro> SisTarefaParametros { get; set; } = new List<SisTarefaParametro>();

    public virtual ICollection<SisFaixaHorario> FaHos { get; set; } = new List<SisFaixaHorario>();

    public virtual ICollection<Usuario> Usus { get; set; } = new List<Usuario>();
}
