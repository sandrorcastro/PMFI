using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscTipoFiscal
    {
        public TribFiscTipoFiscal()
        {
            TribFiscFiscais = new HashSet<TribFiscFiscai>();
            TribFiscOrdemServicos = new HashSet<TribFiscOrdemServico>();
            TribFiscProcedimentos = new HashSet<TribFiscProcedimento>();
            TribFiscReclamacos = new HashSet<TribFiscReclamaco>();
            TribFiscTipoReclamacaos = new HashSet<TribFiscTipoReclamacao>();
            TipoVists = new HashSet<TribFiscTiposVistorium>();
        }

        public int TipoFiscId { get; set; }
        public string? TipoFiscDescricao { get; set; }

        public virtual ICollection<TribFiscFiscai> TribFiscFiscais { get; set; }
        public virtual ICollection<TribFiscOrdemServico> TribFiscOrdemServicos { get; set; }
        public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; }
        public virtual ICollection<TribFiscReclamaco> TribFiscReclamacos { get; set; }
        public virtual ICollection<TribFiscTipoReclamacao> TribFiscTipoReclamacaos { get; set; }

        public virtual ICollection<TribFiscTiposVistorium> TipoVists { get; set; }
    }
}
