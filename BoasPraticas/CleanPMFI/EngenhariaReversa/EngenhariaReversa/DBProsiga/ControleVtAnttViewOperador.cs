using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ControleVtAnttViewOperador
    {
        public string OperadorCpf { get; set; } = null!;
        public string? OperadorNome { get; set; }
        public byte[]? OperadorSenha { get; set; }
        public DateTime? OperadorDataCadastro { get; set; }
        public DateTime? OperadorDataValidade { get; set; }
    }
}
