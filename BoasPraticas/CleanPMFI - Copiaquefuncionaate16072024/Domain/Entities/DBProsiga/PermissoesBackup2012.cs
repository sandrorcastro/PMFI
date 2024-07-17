using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class PermissoesBackup2012
    {
        public string PrmIdform { get; set; } = null!;
        public string PrmIdusuario { get; set; } = null!;
        public string? PrmInclusao { get; set; }
        public string? PrmAlteracao { get; set; }
        public string? PrmRemocao { get; set; }
        public string? PrmRelatorios { get; set; }
        public string? PrmConsultas { get; set; }
    }
}
