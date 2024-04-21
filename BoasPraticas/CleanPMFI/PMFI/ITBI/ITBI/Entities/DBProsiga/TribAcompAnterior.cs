using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribAcompAnterior
{
    public long AcoId { get; set; }

    public long? EdificacaoId { get; set; }

    public long? EmprCmc { get; set; }

    public long? ConId { get; set; }

    public int? AcoTipoId { get; set; }

    public DateTime? AcoData { get; set; }

    /// <summary>
    /// Notificação Fiscal, Auto de Infração, Outros, Termo de Inicio, Devolução, Retenção, Editais, P-Apreensão e Vistoria 
    /// </summary>
    public string? AcoTipoDoc { get; set; }

    public int? AcoNumDoc { get; set; }

    public string? AcoAtendido { get; set; }

    public string? AcoObservacao { get; set; }

    public DateTime? DataInclusao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public virtual TribAcompAntTipoMotivo? AcoTipo { get; set; }

    public virtual TribEdificaco? Edificacao { get; set; }

    public virtual TribEmpresa? EmprCmcNavigation { get; set; }
}
