using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbAciUnidade
    {
        public TbAciUnidade()
        {
            IdInteressados = new HashSet<TbAciInteressado>();
        }

        public int IdUnidade { get; set; }
        public string? NmUnidade { get; set; }
        public int? IdTipoUnidade { get; set; }
        public string? NrTelefones { get; set; }
        public int IdInteressadoAtual { get; set; }

        public virtual TbAciTipoUnidade? IdTipoUnidadeNavigation { get; set; }

        public virtual ICollection<TbAciInteressado> IdInteressados { get; set; }
    }
}
