using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class HabDocApresentado
    {
        public int DocApresentadosId { get; set; }
        public int? AtendimentoId { get; set; }
        public int? DocumentoId { get; set; }
        public string? DocAprNumero { get; set; }
        public DateTime? DocDtAnexacao { get; set; }
        /// <summary>
        /// Usuário que efetuou a anexação do documento
        /// </summary>
        public string? UsuId { get; set; }

        public virtual HabAtendimento? Atendimento { get; set; }
        public virtual HabDocumento? Documento { get; set; }
        public virtual Usuario? Usu { get; set; }
    }
}
