using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribVencimento
    {
        /// <summary>
        /// Informa qual rotina que vai utilizar a tabela de vencimentos
        /// </summary>
        public string TipoTribRotina { get; set; } = null!;
        public int TribVencAno { get; set; }
        public int TipoTribId { get; set; }
        public int TipoTribParcela { get; set; }
        public DateTime TipoTribVencimento { get; set; }
        /// <summary>
        /// Informa se a parcela é Unica ou não.
        /// </summary>
        public string TipoTribParcelaUnica { get; set; } = null!;
        /// <summary>
        /// Percentual de Desconto para pagamento antecipado
        /// </summary>
        public decimal TipoTribPercDescPagAntecipado { get; set; }
        /// <summary>
        /// Tributo que sera gerado para o desconto antecipado.
        /// </summary>
        public int? TipoTribIdpagAntecipado { get; set; }
        /// <summary>
        /// Específico = No vencimento informado no TipoTribVencimento, A Vencer = Irá vencer X dias após a data corrente
        /// </summary>
        public string TipoTribTipoVencimento { get; set; } = null!;
        /// <summary>
        /// Dias a vencer após a data corrente
        /// </summary>
        public int TipoTribDiasAvencer { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? HostInclusao { get; set; }
        public string? ParcelaValorTotal { get; set; }
    }
}
