using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoAtividade
    {
        public int IdSolicitacaoInscricaoAtividade { get; set; }
        public long IdSolicitacaoInscricao { get; set; }
        public string Atividade { get; set; } = null!;
        public bool? FlPrincipal { get; set; }
        public DateTime? DtInicial { get; set; }
        public int? IdAtributo { get; set; }
        public string? DsValor { get; set; }
        public DateTime? DtFim { get; set; }

        public virtual TbConSolicitacaoInscricaoCmc IdSolicitacaoInscricaoNavigation { get; set; } = null!;
    }
}
