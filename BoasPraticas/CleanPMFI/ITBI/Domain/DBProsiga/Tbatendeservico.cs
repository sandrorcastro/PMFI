using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tbatendeservico
    {
        public int Idservico { get; set; }
        public string Nmservico { get; set; } = null!;
        /// <summary>
        /// Tempo de duração do atendimento em minutos.
        /// </summary>
        public int Nrduracaoatendimento { get; set; }
        /// <summary>
        /// Quantos dias para frente pode ser liberado a agenda.
        /// </summary>
        public int Nrproximasdatas { get; set; }
        public int Idlocal { get; set; }
        public string? Dsorientacoes { get; set; }
        /// <summary>
        /// Indica se o atendimento para o agendamento será [P]resencial ou [O]nline
        /// </summary>
        public string? Flatendimento { get; set; }
        /// <summary>
        /// Indica que o agendamento irá ser realizado a partir desta data.
        /// </summary>
        public DateTime? Dtperiodoinicio { get; set; }
        /// <summary>
        /// Indica que o agendamento terminará nesta data.
        /// </summary>
        public DateTime? Dtperiodofim { get; set; }
        /// <summary>
        /// Mensagem enviada por email
        /// </summary>
        public string Dsmsgemail { get; set; } = null!;
        public byte[]? Anexo { get; set; }
        public string Flexigedadosprocesso { get; set; } = null!;
    }
}
