using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribBoletosParaArquivo
    {
        public string? BoleNossoNumero { get; set; }
        /// <summary>
        /// Código de identificação da dívida.
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? DivEmpId { get; set; }
        /// <summary>
        /// Data da inclusão do registro.
        /// </summary>
        public DateTime? BoleDataInclusao { get; set; }
        /// <summary>
        /// Nome do usuário que incluiu o registro.
        /// </summary>
        public string? BoleUsuarioInclusao { get; set; }
    }
}
