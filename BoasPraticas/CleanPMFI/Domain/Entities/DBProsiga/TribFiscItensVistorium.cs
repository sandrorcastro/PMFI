using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscItensVistorium
    {
        public TribFiscItensVistorium()
        {
            TribFiscAutoInfracoesItensVistoria = new HashSet<TribFiscAutoInfracoesItensVistorium>();
            TribFiscItensVistoriaTributos = new HashSet<TribFiscItensVistoriaTributo>();
            TribFiscNotificacos = new HashSet<TribFiscNotificaco>();
            TribFiscVistoriaItensVistoriados = new HashSet<TribFiscVistoriaItensVistoriado>();
            LeiComps = new HashSet<TribLegislacaoComponente>();
        }

        public int ItemVistId { get; set; }
        public string? ItemVistNome { get; set; }
        public int TipoVistId { get; set; }
        public string? ItemVistGeraNotificacao { get; set; }
        public short? ItemVistPrazo { get; set; }
        public long? Textoid { get; set; }
        public string? ItemVistVistoria { get; set; }
        public string? ItemVistTipoInformacaoAdicional { get; set; }
        public long? TextoAutoId { get; set; }
        public string? ItemVistNotaFiscal { get; set; }

        public virtual TribFiscTiposVistorium TipoVist { get; set; } = null!;
        public virtual ICollection<TribFiscAutoInfracoesItensVistorium> TribFiscAutoInfracoesItensVistoria { get; set; }
        public virtual ICollection<TribFiscItensVistoriaTributo> TribFiscItensVistoriaTributos { get; set; }
        public virtual ICollection<TribFiscNotificaco> TribFiscNotificacos { get; set; }
        public virtual ICollection<TribFiscVistoriaItensVistoriado> TribFiscVistoriaItensVistoriados { get; set; }

        public virtual ICollection<TribLegislacaoComponente> LeiComps { get; set; }
    }
}
