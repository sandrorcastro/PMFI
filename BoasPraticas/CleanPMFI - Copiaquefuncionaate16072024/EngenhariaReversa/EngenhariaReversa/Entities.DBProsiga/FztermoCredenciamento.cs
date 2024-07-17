using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    /// <summary>
    /// Credenciamento de Empresas. Apos Credenciamento a empresa pode cadastrar condutores e veiculos.
    /// </summary>
    public partial class FztermoCredenciamento
    {
        /// <summary>
        /// Codigo de Identificacao do Termo de Credenciamento. Inicialmente de Moto-Frete.
        /// </summary>
        public int TermoCredenciamentoId { get; set; }
        /// <summary>
        /// Código de Identificação do Ponto sendo credenciado.
        /// </summary>
        public long? TcpontoId { get; set; }
        /// <summary>
        /// Data Emissao do Credenciamento do Ponto
        /// </summary>
        public DateTime? TcdtEmissao { get; set; }
        /// <summary>
        /// Data de Vencimento da Credencial do Ponto
        /// </summary>
        public DateTime? TcdtVencto { get; set; }
        /// <summary>
        /// Outras informações a respeito do Termo de Credenciamento.
        /// </summary>
        public string? Tcobservacoes { get; set; }

        public virtual Fzponto? Tcponto { get; set; }
    }
}
