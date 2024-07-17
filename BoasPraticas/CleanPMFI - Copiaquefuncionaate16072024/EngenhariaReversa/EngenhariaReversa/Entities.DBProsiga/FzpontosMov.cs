using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    /// <summary>
    /// Cadastro e Manutenção de Atos de Normatização de Pontos e Condutores
    /// </summary>
    public partial class FzpontosMov
    {
        /// <summary>
        /// Código de Identificação da Movimentação de Pontos de Veículos.
        /// </summary>
        public int PontoMovId { get; set; }
        /// <summary>
        /// Código de Identificação do Ponto do Veículo
        /// </summary>
        public long? FzpontoId { get; set; }
        /// <summary>
        /// Código de Identificação do Permissionário do Ponto. Observar que Permissionario do Decreto pode referir-se a outra epoca que nao a atual e não coincidir com o Proprietario Atual do Ponto.
        /// </summary>
        public long? ProprietarioId { get; set; }
        /// <summary>
        /// Tipo da Operação efetuada sobre o ponto, podendo ser: Permissao, Permissao Temporaria, Revogação ou Permuta.
        /// </summary>
        public string? Operacao { get; set; }
        /// <summary>
        /// Tipo do Ato de Normatização. Pode ser Decreto, Portaria ou outro Ato.
        /// </summary>
        public string? AtoTipo { get; set; }
        /// <summary>
        /// Número do Ato.
        /// </summary>
        public int? AtoNumero { get; set; }
        /// <summary>
        /// Data do Ato
        /// </summary>
        public DateTime? AtoData { get; set; }
        /// <summary>
        /// Data do Publicação do Ato
        /// </summary>
        public DateTime? AtoDtPublicacao { get; set; }
        /// <summary>
        /// Numero do Diario Oficial no qual consta a Publicação do Ato.
        /// </summary>
        public int? AtoOrgaoOficialNum { get; set; }
        /// <summary>
        /// Numero da Pagina do Diario Oficial no qual consta a Publicação do Ato.
        /// </summary>
        public int? AtoOrgaoOficialPagina { get; set; }
        /// <summary>
        /// Outras informações a respeito da Movimentação do Ponto.
        /// </summary>
        public string? PontoMovObs { get; set; }
        /// <summary>
        /// Data do Lançamento da Movimentação 
        /// </summary>
        public DateTime? DtLancto { get; set; }

        public virtual Fzponto? Fzponto { get; set; }
        public virtual Contribuinte? Proprietario { get; set; }
    }
}
