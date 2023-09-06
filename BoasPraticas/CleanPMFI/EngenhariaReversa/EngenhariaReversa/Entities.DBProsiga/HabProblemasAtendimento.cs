using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class HabProblemasAtendimento
    {
        public int AtendimentoId { get; set; }
        public int ProblemaId { get; set; }
        public DateTime? DtProbAtendimento { get; set; }
        /// <summary>
        /// Usuário que efetuou a manutenção do problema do atendimento
        /// </summary>
        public string? UsuId { get; set; }

        public virtual HabAtendimento Atendimento { get; set; } = null!;
        public virtual HabProblema Problema { get; set; } = null!;
    }
}
