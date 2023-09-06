using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbTabela
    {
        public TbTabela()
        {
            TbColunas = new HashSet<TbColuna>();
            TbRelatoriosTabelas = new HashSet<TbRelatoriosTabela>();
        }

        public int IdTabela { get; set; }
        public string? NmAmigavel { get; set; }
        public string? DsAjuda { get; set; }
        public string? NmTabelaBanco { get; set; }
        public int? IdBancoDados { get; set; }
        public long? NrObjectId { get; set; }
        public bool? FlPrincipal { get; set; }

        public virtual TbBancosDado? IdBancoDadosNavigation { get; set; }
        public virtual ICollection<TbColuna> TbColunas { get; set; }
        public virtual ICollection<TbRelatoriosTabela> TbRelatoriosTabelas { get; set; }
    }
}
