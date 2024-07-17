using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

/// <summary>
/// Cadastro e Manutenção de Empresas Autorizadas a efetuar Viagens Internacionais pelo Operador
/// </summary>
public partial class FzacessoOperadorEmpresa
{
    public int AcessoOperadorEmpresaId { get; set; }

    /// <summary>
    /// Código de Identificação do Operador. Numero do CPF do Operador
    /// </summary>
    public string AcessoOperadorCpf { get; set; } = null!;

    /// <summary>
    /// Código de Identificação da Empresa. Contribuintes.ConId.
    /// </summary>
    public long? AcessoConId { get; set; }

    public virtual Contribuinte? AcessoCon { get; set; }

    public virtual Fzanttoperador AcessoOperadorCpfNavigation { get; set; } = null!;
}
