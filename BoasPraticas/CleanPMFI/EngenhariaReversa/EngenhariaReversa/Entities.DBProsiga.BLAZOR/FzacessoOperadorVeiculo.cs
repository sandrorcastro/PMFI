using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    /// <summary>
    /// Cadastro e Manutenção de Veiculos Autorizados a Efetuar o Transporte Internacional pelo Operador
    /// </summary>
    public partial class FzacessoOperadorVeiculo
    {
        /// <summary>
        /// Código de Identificação  da Associativa que cria o Perfil de Autorização de Veiculos pelo Operador.
        /// </summary>
        public int AcessoOperadorVeiculoId { get; set; }
        /// <summary>
        /// Código de Identificação do Operador. Numero do CPF do Operador
        /// </summary>
        public string? AcessoOperadorCpf { get; set; }
        /// <summary>
        /// Código de Identificação do Veiculo. Veiculo Autorizado a ser utilizado em Viagens Internacionais pelo Operador
        /// </summary>
        public long? AcessoFzveiId { get; set; }

        public virtual Fzveiculo? AcessoFzvei { get; set; }
        public virtual Fzanttoperador? AcessoOperadorCpfNavigation { get; set; }
    }
}
