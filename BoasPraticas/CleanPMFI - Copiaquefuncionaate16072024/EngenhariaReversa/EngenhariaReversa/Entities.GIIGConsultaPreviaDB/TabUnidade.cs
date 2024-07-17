using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabUnidade
    {
        public TabUnidade()
        {
            TabConsultaAvisos = new HashSet<TabConsultaAviso>();
            TabFuncionarios = new HashSet<TabFuncionario>();
        }

        public short UnidId { get; set; }
        public string? UnidNome { get; set; }
        public string? UnidSigla { get; set; }
        public string? UnidEndereco { get; set; }
        public string? UnidContato { get; set; }
        public string? UninrTelefone { get; set; }

        public virtual ICollection<TabConsultaAviso> TabConsultaAvisos { get; set; }
        public virtual ICollection<TabFuncionario> TabFuncionarios { get; set; }
    }
}
