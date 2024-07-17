using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicCotacaoSimple
    {
        public int IdCotacaoSimples { get; set; }
        public int? IdPessoa { get; set; }
        public int? IdRms { get; set; }
        public int? IdItem { get; set; }
        public decimal? NrQtde { get; set; }
        public decimal? VlTotal { get; set; }
        public decimal? VlUnitario { get; set; }
        public DateTime? DtCotacao { get; set; }
        public string? DsMarca { get; set; }
        public string? DsObservacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbDspIten? IdItemNavigation { get; set; }
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
    }
}
