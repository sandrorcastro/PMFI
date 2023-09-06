using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabFuncionario
    {
        public TabFuncionario()
        {
            TabConsultaAvisos = new HashSet<TabConsultaAviso>();
        }

        public short FuncId { get; set; }
        public string? FuncMatricula { get; set; }
        public string? FuncNome { get; set; }
        public short? UnidId { get; set; }
        public string? FuncResponsavel { get; set; }
        public string? FuncUsuario { get; set; }
        /// <summary>
        /// (A = Ativo, B = Bloqueado)
        /// </summary>
        public string? FuncUsuarioSituacao { get; set; }
        public string? FuncEmail { get; set; }
        public string? FuncRecebeEmail { get; set; }

        public virtual TabUnidade? Unid { get; set; }
        public virtual ICollection<TabConsultaAviso> TabConsultaAvisos { get; set; }
    }
}
