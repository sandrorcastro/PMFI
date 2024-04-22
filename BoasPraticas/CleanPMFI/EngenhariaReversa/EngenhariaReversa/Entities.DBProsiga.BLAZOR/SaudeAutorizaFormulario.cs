using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAutorizaFormulario
    {
        public int IdLogonAutorizado { get; set; }
        public string UsuId { get; set; } = null!;
        public string FrmId { get; set; } = null!;
        public string? Usuario { get; set; }
        public DateTime? Data { get; set; }

        public virtual Formulario Frm { get; set; } = null!;
        public virtual SaudeUsuariosUnidade SaudeUsuariosUnidade { get; set; } = null!;
    }
}
