using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

/// <summary>
/// Cadastro e Manutenção de Contratos (Motoristas e Empresas ) Autorizados a Atuar no Transporte Internacional pelo Operador
/// </summary>
public partial class FzacessoOperadorMotoristum
{
    public int AcessoOperadorMotoristaId { get; set; }

    /// <summary>
    /// Código de Identificação do Operador. Numero do CPF do Operador
    /// </summary>
    public string? AcessoOperadorCpf { get; set; }

    /// <summary>
    /// Código de Identificação do Contrato. Vinculo nao empregaticio entre Empresa e Motorista. 
    /// </summary>
    public int? AcessoContratoId { get; set; }

    public virtual Fzanttcontrato? AcessoContrato { get; set; }

    public virtual Fzanttoperador? AcessoOperadorCpfNavigation { get; set; }
}
