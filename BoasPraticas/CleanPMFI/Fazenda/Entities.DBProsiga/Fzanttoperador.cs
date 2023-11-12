using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

/// <summary>
/// Cadastro e Manutenção de Operadores dos Elementos de Viagens Internacionais(Empresas X Motoristas X Veiculos ) 
/// </summary>
public partial class Fzanttoperador
{
    /// <summary>
    /// Código de Identificação do Operador. Numero do CPF do Operador
    /// </summary>
    public string OperadorCpf { get; set; } = null!;

    /// <summary>
    /// Nome Completo do Operador
    /// </summary>
    public string? OperadorNome { get; set; }

    /// <summary>
    /// Senha do Operador
    /// </summary>
    public byte[]? OperadorSenha { get; set; }

    /// <summary>
    /// Data do Cadastro do Operador. Também pode ser utilizado como Data de Inicio da Validade do Operador.
    /// </summary>
    public DateTime? OperadorDataCadastro { get; set; }

    /// <summary>
    /// Data da Validade do Cadastro do Operador.
    /// </summary>
    public DateTime? OperadorDataValidade { get; set; }

    public virtual ICollection<FzacessoOperadorEmpresa> FzacessoOperadorEmpresas { get; set; } = new List<FzacessoOperadorEmpresa>();

    public virtual ICollection<FzacessoOperadorMotoristum> FzacessoOperadorMotorista { get; set; } = new List<FzacessoOperadorMotoristum>();

    public virtual ICollection<FzacessoOperadorVeiculo> FzacessoOperadorVeiculos { get; set; } = new List<FzacessoOperadorVeiculo>();
}
