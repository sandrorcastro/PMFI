using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    /// <summary>
    /// Cadastro de Cidades revisado no DBPROSiga em 18/01/2021
    /// </summary>
    public partial class Fztbcidade
    {
        public int Idcidade { get; set; }
        public string Nmcidade { get; set; } = null!;
        public int? Idpais { get; set; }
        public string? Dssiglauf { get; set; }
        public string? Cdibgecodigo { get; set; }
        public string? Fzfonetizado { get; set; }
    }
}
