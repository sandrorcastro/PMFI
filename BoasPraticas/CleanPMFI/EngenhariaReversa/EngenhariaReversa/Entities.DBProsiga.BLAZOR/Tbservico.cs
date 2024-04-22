using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Tbservico
    {
        public int Idservico { get; set; }
        public string? Nome { get; set; }
        public string? Icone { get; set; }
        public string? Descricao { get; set; }
        public string? Link { get; set; }
        public int? Idcategoria { get; set; }
        public int? Ativo { get; set; }
        public bool? Publico { get; set; }
        public string? Controller { get; set; }

        public virtual Tbcategorium? IdcategoriaNavigation { get; set; }
    }
}
