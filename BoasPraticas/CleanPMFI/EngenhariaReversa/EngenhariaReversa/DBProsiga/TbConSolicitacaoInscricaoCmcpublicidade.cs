using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbConSolicitacaoInscricaoCmcpublicidade
    {
        public long IdSolicitacaoInscricaoPublicidade { get; set; }
        public long? IdSolicitacaoInscricao { get; set; }
        public int? PublicTipoId { get; set; }
        public string? DsPublicidadeNome { get; set; }
        public int? NrPeriodicidade { get; set; }
        public int? NrUnidMedida { get; set; }
        public int? NrVistoriaNumero { get; set; }
        public int? NrVistoriaAno { get; set; }
        public decimal? NrAreaAberta { get; set; }
        public decimal? NrAreaCoberta { get; set; }
    }
}
