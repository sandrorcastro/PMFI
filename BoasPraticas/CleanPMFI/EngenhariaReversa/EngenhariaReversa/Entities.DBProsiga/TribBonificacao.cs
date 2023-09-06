using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribBonificacao
    {
        public long EdificacaoId { get; set; }
        public short BonificAno { get; set; }
        public short? BonificAnos { get; set; }
        public short? BonifcAnosConsecutivos { get; set; }
        /// <summary>
        /// Usuário que incluiu a baixa
        /// </summary>
        public string? Usuario { get; set; }
        /// <summary>
        /// Nome da maquina que fez a baixa.
        /// </summary>
        public string? Host { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
    }
}
