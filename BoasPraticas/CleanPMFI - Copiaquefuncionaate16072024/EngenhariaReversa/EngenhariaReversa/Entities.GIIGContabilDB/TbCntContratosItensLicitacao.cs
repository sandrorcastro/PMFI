using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntContratosItensLicitacao
    {
        public int IdContratoItemLicitacao { get; set; }
        public int IdContrato { get; set; }
        public int IdItem { get; set; }
        public int NrLote { get; set; }
        public decimal? NrQtde { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public string? DsMarca { get; set; }
        public decimal? NrQtdeAditivada { get; set; }
        public decimal? VlUnitAtualizado { get; set; }
        public decimal? VlTotalAditivado { get; set; }
        public string? FlStatus { get; set; }
        public int? IdPessoa { get; set; }

        public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;
        public virtual TbDspIten IdItemNavigation { get; set; } = null!;
        public virtual TbGerPessoa? IdPessoaNavigation { get; set; }
    }
}
