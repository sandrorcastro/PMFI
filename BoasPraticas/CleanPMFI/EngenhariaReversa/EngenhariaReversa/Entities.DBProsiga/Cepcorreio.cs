using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Cepcorreio
    {
        public string? ColunaLista { get; set; }
        public string? Cep { get; set; }
        public string? BairroNovo { get; set; }
        public string? TipoLogradouro { get; set; }
        public string? Logradouro { get; set; }
        public string? Abreviado { get; set; }
        public string? BairroAntigo { get; set; }
        public int? IdbairroNovo { get; set; }
        public int? Idlogradouro { get; set; }
        /// <summary>
        /// Tem casos na REDESIM de empresas que estão vindo com o CEP antigo. Neste campo vai estar o CEP antigo de um CEP novo.
        /// </summary>
        public string? CepAntigo { get; set; }
        /// <summary>
        /// Campo para indicar se o CEP existe na busca online dos correios. Tem casos de CEP que está em CNPJ que nao existe no BuscaCEP.
        /// </summary>
        public string Flexistenosite { get; set; } = null!;
    }
}
