using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRecMovimentoReceitasDetalhe
    {
        public TbRecMovimentoReceitasDetalhe()
        {
            TbRecMovimentoReceitasDetalheDesmembras = new HashSet<TbRecMovimentoReceitasDetalheDesmembra>();
        }

        /// <summary>
        /// Código para identificar exclusivamente o registro.
        /// </summary>
        public int IdDetalheMovReceita { get; set; }
        public int? IdMovReceita { get; set; }
        /// <summary>
        /// Contribuinte ou Entidade que fez o repasse.
        /// </summary>
        public int? IdPessoa { get; set; }
        public int? IdReceita { get; set; }
        public decimal? VlLancado { get; set; }
        public string? DsHistoricoDetalhe { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public string? FlRestoReceber { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }

        public virtual TbRecMovimentoReceita? IdMovReceitaNavigation { get; set; }
        public virtual TbOrcReceita? IdReceitaNavigation { get; set; }
        public virtual ICollection<TbRecMovimentoReceitasDetalheDesmembra> TbRecMovimentoReceitasDetalheDesmembras { get; set; }
    }
}
