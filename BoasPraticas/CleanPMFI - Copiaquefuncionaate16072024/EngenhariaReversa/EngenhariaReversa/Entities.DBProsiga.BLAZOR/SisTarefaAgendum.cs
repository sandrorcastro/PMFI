using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SisTarefaAgendum
    {
        public SisTarefaAgendum()
        {
            SisTarefaParametrosValores = new HashSet<SisTarefaParametrosValore>();
        }

        public int JoAgId { get; set; }
        public int? TiJoId { get; set; }
        /// <summary>
        /// Data, hora e minuto para execução da tarefa.
        /// </summary>
        public DateTime? JoAgDataHoraIni { get; set; }
        /// <summary>
        /// Data gravada automaticamente pelo sistema qdo. finalizada a tarefa.
        /// </summary>
        public DateTime? JoAgDataHoraFim { get; set; }
        /// <summary>
        /// Para controlar a situação do JOB no banco, pode ser: Aguardando, Rodando, Concluido.
        /// </summary>
        public string JoAgSituacao { get; set; } = null!;
        /// <summary>
        /// Mensagem sobre a situação da agenda da tarefa. Ex. Situação:Finalizada - Mensagem: ERRO ou 30 Registros Afetados.
        /// </summary>
        public string? JoAgMensagem { get; set; }
        /// <summary>
        /// Nome do usuário que agendou o JOB.
        /// </summary>
        public string? UsuId { get; set; }
        /// <summary>
        /// Data da inclusão do JOB.
        /// </summary>
        public DateTime? DataInclusao { get; set; }
        /// <summary>
        /// Nome da maquina que agendou o JOB.
        /// </summary>
        public string? Host { get; set; }
        /// <summary>
        /// Contem o endereço do arquivo gerado
        /// </summary>
        public string? JoAgArquivo { get; set; }

        public virtual SisTarefa? TiJo { get; set; }
        public virtual Usuario? Usu { get; set; }
        public virtual ICollection<SisTarefaParametrosValore> SisTarefaParametrosValores { get; set; }
    }
}
