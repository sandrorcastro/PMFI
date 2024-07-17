using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VisaoUsuario
    {
        public string? UsuNivelAcesso { get; set; }
        public string? UsuAvisaGravacao { get; set; }
        public string? ServNome { get; set; }
        public string? ServCargo { get; set; }
        public string? ServFuncao { get; set; }
        public string? DivNome { get; set; }
        public string? UniNome { get; set; }
        public string? OrgNome { get; set; }
        public string? MemRazaoSocial { get; set; }
        public string UsuId { get; set; } = null!;
        public DateTime? UsuDtvalidade { get; set; }
        public string? UsuDistrProc { get; set; }
        public string? UsuRecProc { get; set; }
        public string? UsuArquivaReabre { get; set; }
    }
}
