using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtiSetore
    {
        public TbCtiSetore()
        {
            TbCtiDespachoSetors = new HashSet<TbCtiDespachoSetor>();
            TbCtiSetoresServidores = new HashSet<TbCtiSetoresServidore>();
        }

        public int IdSetor { get; set; }
        public string? NmSetor { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }

        public virtual ICollection<TbCtiDespachoSetor> TbCtiDespachoSetors { get; set; }
        public virtual ICollection<TbCtiSetoresServidore> TbCtiSetoresServidores { get; set; }
    }
}
