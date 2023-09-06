using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbColuna
    {
        public TbColuna()
        {
            TbRelatoriosColunas = new HashSet<TbRelatoriosColuna>();
        }

        public int IdColuna { get; set; }
        public int? IdTabela { get; set; }
        public short NrObjectId { get; set; }
        public string? NmAmigavel { get; set; }
        public string? NmColuna { get; set; }
        public int? IdTipoColuna { get; set; }
        public short? NrTamanho { get; set; }
        public short? NrDecimais { get; set; }
        public bool? FlChavePrimaria { get; set; }
        public bool? FlChaveEstrangeira { get; set; }
        public int? IdColunaRelacao { get; set; }
        public int? DbColumId { get; set; }
        public bool? IsChecked { get; set; }

        public virtual TbTabela? IdTabelaNavigation { get; set; }
        public virtual ICollection<TbRelatoriosColuna> TbRelatoriosColunas { get; set; }
    }
}
