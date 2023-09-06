using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbRelatorio
    {
        public TbRelatorio()
        {
            TbRelatoriosColunas = new HashSet<TbRelatoriosColuna>();
            TbRelatoriosTabelas = new HashSet<TbRelatoriosTabela>();
        }

        public int IdRelatorio { get; set; }
        public string? DsLogin { get; set; }
        public string? NmRelatorio { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual ICollection<TbRelatoriosColuna> TbRelatoriosColunas { get; set; }
        public virtual ICollection<TbRelatoriosTabela> TbRelatoriosTabelas { get; set; }
    }
}
